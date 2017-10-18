using FarmaciaJa.API.Domain.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Repository;
using FarmaciaJa.API.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace FarmaciaJa.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            return _usuarioRepository.ListarUsuarios();
        }

        public UsuarioDTO BuscarUsuario(int id)
        {
            return _usuarioRepository.BuscarUsuario(id);
        }
    }
}
