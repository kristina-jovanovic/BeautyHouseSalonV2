using AutoMapper;
using Common.Domain;
using Common.DTOs;

namespace WebAPI.Mappings
{
	public class AutoMapperProfiles : Profile
	{
        public AutoMapperProfiles()
        {
            CreateMap<Usluga, UslugaDto>().ReverseMap();
            CreateMap<TipUsluge, TipUslugeDto>().ReverseMap();
            CreateMap<ProfilRadnika, ProfilRadnikaDto>().ReverseMap();
		}
	}
}
