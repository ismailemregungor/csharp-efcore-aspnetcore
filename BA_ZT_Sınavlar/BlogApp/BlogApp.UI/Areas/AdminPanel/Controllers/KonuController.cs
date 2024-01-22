using AutoMapper;
using BlogApp.Application.Models.DTOs.KonuDTOs;
using BlogApp.Application.Services.KonuService;
using BlogApp.Domain.Entites;
using BlogApp.UI.Models.VMs.KonuVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.UI.Areas.AdminPanel.Controllers
{
    [Authorize]
    [Area("AdminPanel")]
    public class KonuController : Controller
    {
        private readonly IKonuService _konuService;
        private readonly IMapper _mapper;

        public KonuController(IKonuService konuService, IMapper mapper)
        {
            _konuService = konuService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var konu = await _konuService.TumKonulariListeleAsync();
            var konuVM = konu.Select(x => _mapper.Map<KonuListeleVM>(x)).ToList();
            return View(konuVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(KonuEkleVM konuEkleVM)
        {
            if (ModelState.IsValid)
            {
                KonuEkleDTO konu = _mapper.Map<KonuEkleDTO>(konuEkleVM);
                await _konuService.EkleAsync(konu);
                return RedirectToAction("Index");
            }
            else
            {
                return View(konuEkleVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            KonuListeleDTO konu = await _konuService.IdGoreKonulariListeleAsync(id);
            if (konu == null)
            {
                return RedirectToAction("NotFound");
            }

            KonuGuncelleVM konuGuncelleVM = _mapper.Map<KonuGuncelleVM>(konu);
            return View(konuGuncelleVM);
        }

        [HttpPost]
        public IActionResult Update(KonuGuncelleVM konuGuncelleVM)
        {
            if (ModelState.IsValid)
            {
                KonuGuncelleDTO konu = _mapper.Map<KonuGuncelleDTO>(konuGuncelleVM);
                _konuService.GuncelleAsync(konu);
                return RedirectToAction("Index");
            }
            else
            {
                return View(konuGuncelleVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            KonuListeleDTO konu = await _konuService.IdGoreKonulariListeleAsync(id);
            Konu silinecekKonu = _mapper.Map<Konu>(konu);

            await _konuService.SilAsync(silinecekKonu.KonuID);
            return RedirectToAction("Index");

        }
    }
}
