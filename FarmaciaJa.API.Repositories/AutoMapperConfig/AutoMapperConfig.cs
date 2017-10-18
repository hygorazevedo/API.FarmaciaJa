using AutoMapper;
using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Domain.DTOs;

namespace FarmaciaJa.API.Repositories.AutoMapperConfig
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x => 
            {
                x.CreateMap<Usuario, UsuarioDTO>().ReverseMap();
                x.CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            });
        }
    }
}
