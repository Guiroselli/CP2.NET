
using AutoMapper;
using MapeamentoInteligentePatio.Application.DTOs;
using MapeamentoInteligentePatio.Domain.Entities;

namespace MapeamentoInteligentePatio.API.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Moto, MotoDTO>().ReverseMap();
            CreateMap<Filial, FilialDTO>().ReverseMap();
        }
    }
}
