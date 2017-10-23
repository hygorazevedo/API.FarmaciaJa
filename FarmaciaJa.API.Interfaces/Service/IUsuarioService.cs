using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        void CriarUsuario(UsuarioDTO usuarioDTO);
        void AlterarUsuario(UsuarioDTO usuarioDTO);
        void RemoverUsuario(UsuarioDTO usuarioDTO);
    }
}
