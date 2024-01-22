using AutoMapper;
using BlogApp.Application.Models.DTOs.AppUserDTOs;
using BlogApp.Domain.Entites;
using BlogApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.AppUserService
{
	public class AppUserService : IAppUserService
	{
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public AppUserService(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_mapper = mapper;
			_userManager = userManager;
			_signInManager = signInManager;
		}

		public int GetUserID(ClaimsPrincipal claims)
		{
			return int.Parse(_userManager.GetUserId(claims));
		}

		public async Task<IdentityResult> GuncelleAsync(AppUserGuncelleDTO appUserGuncelleDTO)
		{
			if (appUserGuncelleDTO != null)
			{
				var existingUser = await _userManager.FindByIdAsync(appUserGuncelleDTO.Id);
				if (existingUser != null)
				{
					existingUser.Ad = appUserGuncelleDTO.Ad;
					existingUser.Soyad = appUserGuncelleDTO.Soyad;
					existingUser.Email = appUserGuncelleDTO.Email;
					existingUser.PhoneNumber = appUserGuncelleDTO.PhoneNumber;

					existingUser.GuncellemeTarihi = DateTime.Now;
					existingUser.KayitDurumu = KayitDurumu.Güncellendi;

					var result = await _userManager.UpdateAsync(existingUser);
					return result;
				}
				else
				{
					return IdentityResult.Failed(new IdentityError { Description = "Kullanıcı bulunamadı." });
				}
			}
			else
			{
				return IdentityResult.Failed(new IdentityError { Description = "Güncelleme işleminde hata alındı." });
			}
		}

		public async Task<AppUserListeleDTO> IdGoreUserListeleAsync(string id)
		{
			var user = await _userManager.FindByIdAsync(id);
			var mappedUser = _mapper.Map<AppUserListeleDTO>(user);
			return mappedUser;
		}

		public async Task<LoginReturnDTO> LoginAsync(LoginDTO loginDTO)
		{
			LoginReturnDTO returnDTO = new LoginReturnDTO() { IsUser = false, IsAdmin = false };

			var user = await _userManager.FindByEmailAsync(loginDTO.Email);
			if (user == null)
			{
				return returnDTO;
			}
			var passwordIsCorrect = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
			if (!passwordIsCorrect)
			{
				return returnDTO;
			}
			await _signInManager.SignInAsync(user, true);
			returnDTO.IsUser = true;
			returnDTO.IsAdmin = await _userManager.IsInRoleAsync(user, "Admin");
			return returnDTO;
		}

		public async Task LogOutAsync()
		{
			await _signInManager.SignOutAsync();
		}

		public async Task<bool> RegisterAsync(RegisterDTO registerDTO)
		{
			if (registerDTO != null)
			{
				AppUser user = _mapper.Map<AppUser>(registerDTO);

				string[] emailParts = registerDTO.Email.Split('@');
				if (emailParts.Length >= 2)
				{
					string username = emailParts[0];
					string[] nameParts = username.Split('.');

					if (nameParts.Length >= 2)
					{
						user.UserName = username;
						user.Ad = nameParts[0];
						user.Soyad = nameParts[1];
					}
					else
					{
						user.UserName = username;
						user.Ad = "?";
						user.Soyad = "?";
					}
				}
				else
				{
					user.UserName = "?";
					user.Ad = "?";
					user.Soyad = "?";
				}

				var addUser = await _userManager.CreateAsync(user, registerDTO.Password);
				await _userManager.IsInRoleAsync(user, "Uye");
				return addUser.Succeeded;
			}
			else
			{
				throw new Exception("Ekleme işleminde hata alındı..");
			}
		}
	}
}
