using AutoMapper;
using BlogApp.Application.Models.DTOs.AppUserDTOs;
using BlogApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.AutoMapper
{
	public class AppUserMapper : Profile
	{
		public AppUserMapper()
		{
			CreateMap<AppUser, RegisterDTO>().ReverseMap();
			CreateMap<AppUser, LoginDTO>().ReverseMap();
			CreateMap<AppUser, AppUserGuncelleDTO>().ReverseMap();
			CreateMap<AppUser, AppUserListeleDTO>().ReverseMap();
		}
	}
}
