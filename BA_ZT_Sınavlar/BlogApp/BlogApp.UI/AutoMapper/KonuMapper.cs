using AutoMapper;
using BlogApp.Application.Models.DTOs.KonuDTOs;
using BlogApp.UI.Models.VMs.KonuVMs;

namespace BlogApp.UI.AutoMapper
{
    public class KonuMapper : Profile
    {
        public KonuMapper()
        {
            CreateMap<KonuListeleDTO, KonuListeleVM>().ReverseMap();
            CreateMap<KonuEkleDTO, KonuEkleVM>().ReverseMap();
            CreateMap<KonuGuncelleDTO, KonuGuncelleVM>().ReverseMap();
            CreateMap<KonuListeleDTO, KonuGuncelleVM>().ReverseMap();
        }
    }
}
