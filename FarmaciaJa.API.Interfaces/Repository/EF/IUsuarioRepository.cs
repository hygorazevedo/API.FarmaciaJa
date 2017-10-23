using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Interfaces.Repository.EF
{
    public interface IUsuarioRepository
    {
        void CriarUsuario(UsuarioDTO usuarioDTO);
        void AlterarUsuario(UsuarioDTO usuarioDTO);
        void RemoverUsuario(UsuarioDTO usuarioDTO);
    }
}
