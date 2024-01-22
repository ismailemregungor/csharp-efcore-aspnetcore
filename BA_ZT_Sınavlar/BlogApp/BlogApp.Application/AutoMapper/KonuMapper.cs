using AutoMapper;
using BlogApp.Application.Models.DTOs.KonuDTOs;
using BlogApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.AutoMapper
{
	public class KonuMapper : Profile
	{
		public KonuMapper()
		{
			CreateMap<Konu, KonuListeleDTO>().ReverseMap();
			CreateMap<Konu, KonuEkleDTO>().ReverseMap();
			CreateMap<Konu, KonuGuncelleDTO>().ReverseMap();
		}
	}
}
