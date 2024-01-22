using BlogApp.Application.Models.DTOs.AppUserDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Services.AppUserService
{
	public interface IAppUserService
	{
		Task<bool> RegisterAsync(RegisterDTO registerDTO);
		Task<LoginReturnDTO> LoginAsync(LoginDTO loginDTO);
		Task LogOutAsync();
		Task<IdentityResult> GuncelleAsync(AppUserGuncelleDTO appUserGuncelleDTO);
		Task<AppUserListeleDTO> IdGoreUserListeleAsync(string id);
		int GetUserID(ClaimsPrincipal claims);
	}
}
