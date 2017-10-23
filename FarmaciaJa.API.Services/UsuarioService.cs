using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Service;
using FarmaciaJa.API.Interfaces.Repository.EF;

namespace FarmaciaJa.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void CriarUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.CriarUsuario(usuarioDTO);
        }

        public void AlterarUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.AlterarUsuario(usuarioDTO);
        }

        public void RemoverUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.RemoverUsuario(usuarioDTO);
        }
    }
}
