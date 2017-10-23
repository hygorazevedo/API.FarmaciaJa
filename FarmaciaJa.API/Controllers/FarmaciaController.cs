using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Interfaces.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;

namespace FarmaciaJa.API.Controllers
{
    public class FarmaciaController : ApiController
    {
        private IFarmaciaReadOnlyRepository _farmaciaReadOnly;
        private IFarmaciaService _farmaciaService;

        public FarmaciaController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _farmaciaReadOnly = kernel.Get<IFarmaciaReadOnlyRepository>();
            _farmaciaService = kernel.Get<IFarmaciaService>();
        }

        [Route("api/Farmacia/ListarFarmacias")]
        [HttpGet]
        public IEnumerable<FarmaciaDTO> ListarFarmacias()
        {
            return _farmaciaReadOnly.ListarFarmacias();
        }

        [Route("api/Farmacia/BuscarFarmacia/{id}")]
        [HttpGet]
        public IHttpActionResult BuscarFarmacia(int id)
        {
            var farmaciaDTO = _farmaciaReadOnly.BuscarFarmacia(id);
            if (farmaciaDTO._id == 0)
            {
                return NotFound();
            }
            return Ok(farmaciaDTO);
        }

        [Route("api/Farmacia/CriarFarmacia")]
        [HttpPost]
        public IHttpActionResult CriarFarmacia(FarmaciaDTO farmacia)
        {
            try
            {
                var farmaciaDTO = _farmaciaReadOnly.BuscarFarmacia(farmacia._id);
                if (farmaciaDTO._id > 0)
                {
                    return BadRequest();
                }
                _farmaciaService.CriarFarmacia(farmacia);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Farmacia/AlterarFarmacia")]
        [HttpPut]
        public IHttpActionResult AlterarFarmacia(FarmaciaDTO farmacia)
        {
            try
            {
                _farmaciaService.AlterarFarmacia(farmacia);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Farmacia/RemoverFarmacia/{id}")]
        [HttpDelete]
        public IHttpActionResult RemoverFarmacia(int id)
        {
            try
            {
                var farmaciaDTO = _farmaciaReadOnly.BuscarFarmacia(id);
                if (farmaciaDTO._id == 0)
                {
                    return NotFound();
                }
                _farmaciaService.RemoverFarmacia(farmaciaDTO);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }
    }
}
