using AutoMapper;
using BlogApp.Application.Models.DTOs.MakaleDTOs;
using BlogApp.Domain.Entites;
using BlogApp.Domain.Enums;
using BlogApp.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.MakaleService
{
    public class MakaleService : IMakaleService
    {
        private readonly IMakaleRepository _makaleRepository;
        private readonly IMapper _mapper;

        public MakaleService(IMakaleRepository makaleRepository, IMapper mapper)
        {
            _makaleRepository = makaleRepository;
            _mapper = mapper;
        }

        public async Task<bool> EkleAsync(MakaleEkleDTO makaleEkleDTO)
        {
            if (makaleEkleDTO != null)
            {
                Makale makale = _mapper.Map<Makale>(makaleEkleDTO);
                var result = await _makaleRepository.EkleAsync(makale);
                return result;
            }
            else
            {
                throw new Exception("Ekleme işleminde hata alındı..");
            }
        }

        public async Task GuncelleAsync(MakaleGuncelleDTO makaleGuncelleDTO)
        {
            if (makaleGuncelleDTO != null)
            {
                Makale makale = _mapper.Map<Makale>(makaleGuncelleDTO);
                makale.GuncellemeTarihi = DateTime.Now;
                makale.KayitDurumu = KayitDurumu.Güncellendi;
                await _makaleRepository.GuncelleAsync(makale);
            }
            else
            {
                throw new Exception("Güncelleme işleminde hata alındı..");
            }
        }

        public async Task<MakaleListeleDTO> IdGoreMakaleleriListeleAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            var makaleQuery = _makaleRepository.HepsiniGetir()
                .Where(x => x.MakaleID == id)
                .Include(x => x.Konu)
                .Include(x => x.AppUser)
                .OrderBy(x => x.MakaleID);

            var makale = await makaleQuery.FirstOrDefaultAsync();

            if (makale == null)
            {
                return null;
            }

            MakaleListeleDTO makaleListeleDTO = _mapper.Map<MakaleListeleDTO>(makale);
            return makaleListeleDTO;
        }

        public async Task<IEnumerable<MakaleListeleDTO>> KonuGoreMakaleleriListeleAsync(int konuID)
        {
            var makaleQuery = _makaleRepository.HepsiniGetir()
                .Where(x => x.KayitDurumu != KayitDurumu.Pasif && x.KonuID == konuID)
                .Include(x => x.AppUser)
                .OrderBy(x => x.KonuID);

            var makaleListesi = await makaleQuery.ToListAsync();
            var listDTO = makaleListesi.Select(x => _mapper.Map<MakaleListeleDTO>(x));
            return listDTO;
        }
        public async Task<bool> SilAsync(int id)
        {
            var silinecekMakale = await _makaleRepository.HerhangiBiriniBulAsync(c => c.MakaleID == id);

            if (silinecekMakale != null)
            {
                silinecekMakale.SilmeTarihi = DateTime.Now;
                silinecekMakale.KayitDurumu = KayitDurumu.Pasif;
                var result = await _makaleRepository.GuncelleAsync(silinecekMakale);
                return result;
            }
            else
            {
                throw new Exception("Silme işleminde hata alındı..");
            }
        }

        public async Task<IEnumerable<MakaleListeleDTO>> TumMakaleleriListeleAsync()
        {
            var makaleQuery = _makaleRepository.HepsiniGetir()
                .Where(x => x.KayitDurumu != KayitDurumu.Pasif)
                .Include(x => x.Konu)
                .Include(x => x.AppUser)
                .OrderByDescending(x => x.MakaleID);

            var makaleListesi = await makaleQuery.ToListAsync();
            var listDTO = makaleListesi.Select(x => _mapper.Map<MakaleListeleDTO>(x));

            return listDTO;
        }

        public async Task<IEnumerable<MakaleListeleDTO>> UserGoreMakaleleriListeleAsync(string userID)
        {
            var makaleQuery = _makaleRepository.HepsiniGetir()
                .Where(x => (x.KayitDurumu != KayitDurumu.Pasif && x.AppUserID == userID))
                .Include(x => x.Konu)
                .Include(x => x.AppUser)
                .OrderBy(x => x.AppUserID);

            var makaleListesi = await makaleQuery.ToListAsync();
            var listDTO = makaleListesi.Select(x => _mapper.Map<MakaleListeleDTO>(x));

            return listDTO;

        }
    }
}
