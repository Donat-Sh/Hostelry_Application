using AutoMapper;
using HostelryAPI.APIModels.UserModels;
using HostelryAPI.APIModels.VM;
using HostelryWeb.WebModels.Dto;
using HostelryWeb.WebModels.RegistrationModels;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>()
               .ReverseMap();
            CreateMap<Villa, VillaCreateDTO>()
                .ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>()
                .ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>()
                .ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>()
                .ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>()
                .ReverseMap();

            CreateMap<ApplicationUser, UserDTO>()
               .ReverseMap();
        }
    }
}
