using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Domain.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Service;
using Ninject;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;

namespace FarmaciaJa.API.Controllers
{
    public class UsuarioController : ApiController
    {
        private IUsuarioService _usuarioService;

        public UsuarioController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _usuarioService = kernel.Get<IUsuarioService>();
        }

        [Route("api/Usuario/ListarUsuarios")]
        [HttpGet]
        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            return _usuarioService.ListarUsuarios();
        }

        [Route("api/Usuario/BuscarUsuario/{id}")]
        [HttpGet]
        public UsuarioDTO BuscarUsuario(int id)
        {
            return _usuarioService.BuscarUsuario(id);
        }
    }
}
