using AutoMapper;
using BlogApp.Application.Models.DTOs.KonuDTOs;
using BlogApp.Application.Models.DTOs.MakaleDTOs;
using BlogApp.Application.Services.AppUserService;
using BlogApp.Application.Services.KonuService;
using BlogApp.Application.Services.MakaleService;
using BlogApp.Domain.Entites;
using BlogApp.UI.Models.VMs.KonuVMs;
using BlogApp.UI.Models.VMs.MakaleVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogApp.UI.Areas.UyePanel.Controllers
{
    [Authorize]
    [Area("UyePanel")]
    public class MakaleController : Controller
    {
        private readonly IMakaleService _makaleService;
        private readonly IKonuService _konuService;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public MakaleController(IMakaleService makaleService, IKonuService konuService, IMapper mapper, IAppUserService appUserService)
        {
            _makaleService = makaleService;
            _konuService = konuService;
            _mapper = mapper;
            _appUserService = appUserService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var makaleler = await _makaleService.TumMakaleleriListeleAsync();
            var makaleVM = _mapper.Map<List<MakaleListeleVM>>(makaleler);

            Random rnd = new Random();
            var shuffledMakaleVM = makaleVM.OrderBy(x => rnd.Next()).Take(20).ToList();

            return View(shuffledMakaleVM);
        }



        [HttpGet]
        public async Task<IActionResult> UserArticleList()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var makale = await _makaleService.UserGoreMakaleleriListeleAsync(user);
            var makaleVM = makale.Select(x => _mapper.Map<MakaleListeleVM>(x)).ToList();
            return View(makaleVM);
        }


        [HttpGet]
        public async Task<IActionResult> ArticleBySubjectList(int subjectId)
        {
            var konu = await _konuService.IdGoreKonulariListeleAsync(subjectId);

            if (konu == null)
            {
                return NotFound();
            }

            var makaleler = await _makaleService.KonuGoreMakaleleriListeleAsync(konu.KonuID);
            var makaleVM = makaleler.Select(x => _mapper.Map<MakaleListeleVM>(x)).ToList();

            return View(makaleVM);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            MakaleListeleDTO makaleListeleDTO = await _makaleService.IdGoreMakaleleriListeleAsync(id);
            if (makaleListeleDTO == null)
            {
                return NotFound();
            }

            MakaleListeleVM makaleDetaylari = _mapper.Map<MakaleListeleVM>(makaleListeleDTO);

            if (makaleDetaylari.AppUser == null)
            {
                makaleDetaylari.AppUser = new AppUser();
            }
            makaleDetaylari.AppUser.Id = user;

            return View(makaleDetaylari);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var konular = await _konuService.TumKonulariListeleAsync();
            List<KonuListeleVM> konuListesi = konular.Select(x => _mapper.Map<KonuListeleDTO, KonuListeleVM>(x)).ToList();

            MakaleEkleVM makaleEkleVM = new MakaleEkleVM
            {
                Konular = konuListesi
            };
            return View(makaleEkleVM);
        }


        [HttpPost]
        public IActionResult Create(MakaleEkleVM makaleEkleVM)
        {
            if (User.Identity.IsAuthenticated)
            {
                try
                {
                    makaleEkleVM.AppUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    MakaleEkleDTO makaleEkleDTO = _mapper.Map<MakaleEkleDTO>(makaleEkleVM);
                    _makaleService.EkleAsync(makaleEkleDTO);
                    return RedirectToAction("Index");

                }
                catch (ArgumentNullException ex)
                {
                    return BadRequest(ex.Message);
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
            return RedirectToAction("Register", "AppUser");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {

            var konular = await _konuService.TumKonulariListeleAsync();
            List<KonuListeleVM> konuListesi = konular.Select(x => _mapper.Map<KonuListeleDTO, KonuListeleVM>(x)).ToList();

            MakaleListeleDTO makale = await _makaleService.IdGoreMakaleleriListeleAsync(id);
            if (makale == null)
            {
                return RedirectToAction("NotFound");
            }
            MakaleGuncelleVM makaleGuncelleVM = _mapper.Map<MakaleGuncelleVM>(makale);
            makaleGuncelleVM.Konular = konuListesi;
            return View(makaleGuncelleVM);
        }



        [HttpPost]
        public async Task<IActionResult> Update(MakaleGuncelleVM makaleGuncelleVM)
        {
            if (User.Identity.IsAuthenticated)
            {
                try
                {
                    makaleGuncelleVM.AppUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    MakaleGuncelleDTO makaleGuncelleDTO = _mapper.Map<MakaleGuncelleDTO>(makaleGuncelleVM);
                    await _makaleService.GuncelleAsync(makaleGuncelleDTO);
                    return RedirectToAction("Index");

                }
                catch (ArgumentNullException ex)
                {
                    return BadRequest(ex.Message);
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
            return RedirectToAction("Register", "AppUser");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                MakaleListeleDTO makaleListeleDTO = await _makaleService.IdGoreMakaleleriListeleAsync(Id);
                Makale makale = _mapper.Map<Makale>(makaleListeleDTO);

                await _makaleService.SilAsync(makale.MakaleID);
                return RedirectToAction("Index", "Makale");

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Index");
            }
        }
    }
}
