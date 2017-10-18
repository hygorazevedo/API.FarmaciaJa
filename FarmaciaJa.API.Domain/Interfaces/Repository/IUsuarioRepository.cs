using FarmaciaJa.API.Domain.DTOs;
using System.Collections.Generic;

namespace FarmaciaJa.API.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioDTO> ListarUsuarios();
        UsuarioDTO BuscarUsuario(int id);
    }
}
