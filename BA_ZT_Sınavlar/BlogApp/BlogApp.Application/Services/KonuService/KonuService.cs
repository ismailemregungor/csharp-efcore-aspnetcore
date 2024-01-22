using AutoMapper;
using BlogApp.Application.Models.DTOs.KonuDTOs;
using BlogApp.Domain.Entites;
using BlogApp.Domain.Enums;
using BlogApp.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.KonuService
{
    public class KonuService : IKonuService
    {
        private readonly IKonuRepository _konuRepository;
        private readonly IMapper _mapper;

        public KonuService(IKonuRepository konuRepository, IMapper mapper)
        {
            _konuRepository = konuRepository;
            _mapper = mapper;
        }

        public async Task<bool> EkleAsync(KonuEkleDTO konuEkleDTO)
        {
            if (konuEkleDTO != null)
            {
                Konu konu = _mapper.Map<Konu>(konuEkleDTO);
                var result = await _konuRepository.EkleAsync(konu);
                return result;
            }
            else
            {
                throw new Exception("Ekleme işleminde hata alındı..");
            }
        }

        public async Task GuncelleAsync(KonuGuncelleDTO konuGuncelleDTO)
        {
            if (konuGuncelleDTO != null)
            {
                Konu konu = _mapper.Map<Konu>(konuGuncelleDTO);
                konu.GuncellemeTarihi = DateTime.Now;
                konu.KayitDurumu = KayitDurumu.Güncellendi;
                await _konuRepository.GuncelleAsync(konu);
            }
            else
            {
                throw new Exception("Güncelleme işleminde hata alındı...");
            }
        }

        public async Task<KonuListeleDTO> IdGoreKonulariListeleAsync(int id)
        {
            if (id > 0)
            {
                Konu konu = await _konuRepository.HerhangiBiriniBulAsync(x => x.KonuID == id);
                KonuListeleDTO subjectDTO = _mapper.Map<KonuListeleDTO>(konu);
                return subjectDTO;
            }
            else
            {
                throw new Exception("Böyle bir id değeri yoktur..");
            }
        }

        public async Task<bool> SilAsync(int id)
        {
            var silinecekKonu = await _konuRepository.HerhangiBiriniBulAsync(c => c.KonuID == id);

            if (silinecekKonu != null)
            {
                silinecekKonu.SilmeTarihi = DateTime.Now;
                silinecekKonu.KayitDurumu = KayitDurumu.Pasif;
                var result = await _konuRepository.GuncelleAsync(silinecekKonu);
                return result;
            }
            else
            {
                throw new Exception("Silme işleminde hata alındı..");
            }
        }

        public async Task<IEnumerable<KonuListeleDTO>> TumKonulariListeleAsync()
        {
            var konuListesi = _konuRepository.HepsiniGetir()
                                .Where(x => x.KayitDurumu != KayitDurumu.Pasif)
                                .OrderBy(x => x.KonuID) 
                                .ToList();

            var listDTO = konuListesi.Select(x => _mapper.Map<KonuListeleDTO>(x));
            return await Task.FromResult(listDTO);
        }

    }
}
