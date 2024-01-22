using AutoMapper;
using BlogApp.Application.Models.DTOs.MakaleDTOs;
using BlogApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.AutoMapper
{
	public class MakaleMapper : Profile
	{
		public MakaleMapper()
		{
			CreateMap<Makale, MakaleListeleDTO>().ReverseMap();
			CreateMap<Makale, MakaleEkleDTO>().ReverseMap();
			CreateMap<Makale, MakaleGuncelleDTO>().ReverseMap();
		}
	}
}
