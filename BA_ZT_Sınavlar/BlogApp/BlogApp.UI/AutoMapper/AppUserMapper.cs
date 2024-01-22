using AutoMapper;
using BlogApp.Application.Models.DTOs.AppUserDTOs;
using BlogApp.UI.Models.VMs.AppUserVMs;

namespace BlogApp.UI.AutoMapper
{
	public class AppUserMapper : Profile
	{
		public AppUserMapper()
		{
			CreateMap<RegisterDTO, RegisterVM>().ReverseMap();
			CreateMap<LoginDTO, LoginVM>().ReverseMap();
			CreateMap<AppUserGuncelleDTO, AppUserGuncelleVM>().ReverseMap();
			CreateMap<AppUserListeleDTO, AppUserListeleVM>().ReverseMap();
			CreateMap<AppUserListeleDTO, AppUserGuncelleVM>().ReverseMap();
			CreateMap<AppUserListeleDTO, AppUserGuncelleDTO>().ReverseMap();
		}
	}
}
