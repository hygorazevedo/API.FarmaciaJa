using FarmaciaJa.API.Domain.DTOs;
using System.Collections.Generic;

namespace FarmaciaJa.API.Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioDTO> ListarUsuarios();
        UsuarioDTO BuscarUsuario(int id);
    }
}
