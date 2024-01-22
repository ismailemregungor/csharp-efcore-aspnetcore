using AutoMapper;
using BlogApp.Application.Models.DTOs.MakaleDTOs;
using BlogApp.UI.Models.VMs.MakaleVMs;

namespace BlogApp.UI.AutoMapper
{
    public class MakaleMapper : Profile
    {
        public MakaleMapper()
        {
            CreateMap<MakaleListeleDTO, MakaleListeleVM>().ReverseMap();
            CreateMap<MakaleEkleDTO, MakaleEkleVM>()
                .ForMember(dest => dest.Konular, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<MakaleGuncelleDTO, MakaleGuncelleVM>().ReverseMap();
            CreateMap<MakaleListeleDTO, MakaleGuncelleVM>().ReverseMap();
        }
    }
}
