using FarmaciaJa.API.Adapters.DTOs;
using System.Collections.Generic;

namespace FarmaciaJa.API.Domain.Interfaces.Repository.ReadOnly
{
    public interface IUsuarioReadOnlyRepository
    {
        List<UsuarioDTO> ListarUsuarios();
        UsuarioDTO BuscarUsuario(int id);
    }
}
