using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Domain.Interfaces.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;

namespace FarmaciaJa.API.Controllers
{
    public class UsuarioController : ApiController
    {
        private IUsuarioReadOnlyRepository _usuarioReadOnly;
        private IUsuarioService _usuarioService;

        public UsuarioController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _usuarioReadOnly = kernel.Get<IUsuarioReadOnlyRepository>();
            _usuarioService = kernel.Get<IUsuarioService>();
        }

        [Route("api/Usuario/ListarUsuarios")]
        [HttpGet]
        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            return _usuarioReadOnly.ListarUsuarios();
        }

        [Route("api/Usuario/BuscarUsuario/{id}")]
        [HttpGet]
        public IHttpActionResult BuscarUsuario(int id)
        {
            var usuarioDTO = _usuarioReadOnly.BuscarUsuario(id);
            if (usuarioDTO._id == 0)
            {
                return NotFound();
            }
            return Ok(usuarioDTO);
        }

        [Route("api/Usuario/CriarUsuario")]
        [HttpPost]
        public IHttpActionResult CriarUsuario(UsuarioDTO usuario)
        {
            try
            {
                var usuarioDTO = _usuarioReadOnly.BuscarUsuario(usuario._id);
                if (usuarioDTO._id > 0)
                {
                    return BadRequest();
                }
                _usuarioService.CriarUsuario(usuario);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Usuario/AlterarUsuario")]
        [HttpPut]
        public IHttpActionResult AlterarUsuario(UsuarioDTO usuario)
        {
            try
            {
                _usuarioService.AlterarUsuario(usuario);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Usuario/RemoverUsuario/{id}")]
        [HttpDelete]
        public IHttpActionResult RemoverUsuario(int id)
        {
            try
            {
                var usuarioDTO = _usuarioReadOnly.BuscarUsuario(id);
                if (usuarioDTO._id == 0)
                {
                    return NotFound();
                }
                _usuarioService.RemoverUsuario(usuarioDTO);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }
    }
}
