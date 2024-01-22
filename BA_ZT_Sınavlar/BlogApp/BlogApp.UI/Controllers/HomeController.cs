using AutoMapper;
using BlogApp.Application.Models.DTOs.MakaleDTOs;
using BlogApp.Application.Services.AppUserService;
using BlogApp.Application.Services.KonuService;
using BlogApp.Application.Services.MakaleService;
using BlogApp.Domain.Entites;
using BlogApp.UI.Models;
using BlogApp.UI.Models.VMs.MakaleVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BlogApp.UI.Controllers
{
	public class HomeController : Controller
	{
        private readonly IMakaleService _makaleService;
        private readonly IKonuService _konuService;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public HomeController(IMakaleService makaleService, IKonuService konuService, IAppUserService appUserService, IMapper mapper)
        {
            _makaleService = makaleService;
            _konuService = konuService;
            _appUserService = appUserService;
            _mapper = mapper;
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
    }
}