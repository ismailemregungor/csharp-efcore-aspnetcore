using AutoMapper;
using BlogApp.Application.Models.DTOs.AppUserDTOs;
using BlogApp.Application.Services.AppUserService;
using BlogApp.Domain.Entites;
using BlogApp.UI.Models.VMs.AppUserVMs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogApp.UI.Controllers
{
	public class AppUserController : Controller
	{

		private readonly IAppUserService _appUserService;
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;

		public AppUserController(IAppUserService appUserService, IMapper mapper, UserManager<AppUser> userManager)
		{
			_appUserService = appUserService;
			_mapper = mapper;
			_userManager = userManager;
		}

        [HttpGet]
        public async Task<IActionResult> Index()
		{
			var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			AppUserListeleDTO users = await _appUserService.IdGoreUserListeleAsync(currentUserId);
			AppUserListeleVM userVMs = _mapper.Map<AppUserListeleVM>(users);
			return View(userVMs);
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterVM registerVM)
		{
			if (ModelState.IsValid)
			{
				var user = _mapper.Map<RegisterDTO>(registerVM);
				var result = await _appUserService.RegisterAsync(user);
				if (result)
				{
					return RedirectToAction("Login", "AppUser");
				}
				else
				{
					ModelState.AddModelError("Password", "An error occurred during registration.");
				}
			}
			return View(registerVM);
		}



		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginVM loginVM)
		{
			if (ModelState.IsValid)
			{
				var loginDTO = _mapper.Map<LoginDTO>(loginVM);
				var result = await _appUserService.LoginAsync(loginDTO);
				if (result.IsUser)
				{
					var claims = new List<Claim>

				{
				new Claim(ClaimTypes.Name, loginDTO.Email)
				};

					var claimsIdentity = new ClaimsIdentity(claims, "login");

					ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
					await HttpContext.SignInAsync(principal);

					if (result.IsAdmin)
					{
						return RedirectToAction("Index", "Konu", new { Area = "AdminPanel" });
					}
					else
					{
						return RedirectToAction("Index", "Makale", new { Area = "UyePanel" });
					}

				}
			}
			return BadRequest();
		}

		[Authorize]
		public async Task<IActionResult> LogOut()
		{
			await _appUserService.LogOutAsync();
			await HttpContext.SignOutAsync();
			return RedirectToAction("Login", "AppUser");
		}

		[HttpGet]
		public async Task<IActionResult> Update(string id)
		{

			var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
			id = user;

			AppUserListeleDTO appUserListeleDTO = await _appUserService.IdGoreUserListeleAsync(id);

			if (appUserListeleDTO == null)
			{
				return RedirectToAction("NotFound");
			}

			AppUserGuncelleVM appUserGuncelleVM = _mapper.Map<AppUserGuncelleVM>(appUserListeleDTO);
			return View(appUserGuncelleVM);
		}

		[HttpPost]
		public async Task<IActionResult> Update(AppUserGuncelleVM appUserGuncelleVM)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var user = _mapper.Map<AppUserGuncelleDTO>(appUserGuncelleVM);
					var result = await _appUserService.GuncelleAsync(user);
					if (result.Succeeded)
					{
						return RedirectToAction("Index", "AppUser");
					}
					else
					{
						foreach (var error in result.Errors)
						{
							ModelState.AddModelError(string.Empty, error.Description);
						}
					}
				}
				return View(appUserGuncelleVM);
			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(appUserGuncelleVM);
			}

		}
	}
}
