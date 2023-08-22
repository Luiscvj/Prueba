using API.Dtos;
using AutoMapper;

namespace API.Controllers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Alquiler,AlquilerDto>().ReverseMap();
        CreateMap<Sucursal,SucursalDto>().ReverseMap();
        CreateMap<Automovil,AutomovilDto>().ReverseMap();
        CreateMap<Sucursal_Automovil,Sucursal_AutomovilDto>().ReverseMap();
    }
}