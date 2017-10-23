using AutoMapper;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain;

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
                x.CreateMap<Farmacia, FarmaciaDTO>().ReverseMap();
                x.CreateMap<Produto, ProdutoDTO>().ReverseMap();
            });
        }
    }
}
