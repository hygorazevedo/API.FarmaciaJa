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
    public class ProdutoController : ApiController
    {
        private IProdutoReadOnlyRepository _produtoReadOnly;
        private IProdutoService _produtoService;

        public ProdutoController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _produtoReadOnly = kernel.Get<IProdutoReadOnlyRepository>();
            _produtoService = kernel.Get<IProdutoService>();
        }

        [Route("api/Produto/ListarProdutos")]
        [HttpGet]
        public IEnumerable<ProdutoDTO> ListarProdutos()
        {
            return _produtoReadOnly.ListarProdutos();
        }

        [Route("api/Produto/BuscarProduto/{id}")]
        [HttpGet]
        public IHttpActionResult BuscarProduto(int id)
        {
            var produtoDTO = _produtoReadOnly.BuscarProduto(id);
            if (produtoDTO._id == 0)
            {
                return NotFound();
            }
            return Ok(produtoDTO);
        }

        [Route("api/Produto/CriarProduto")]
        [HttpPost]
        public IHttpActionResult CriarProduto(ProdutoDTO produto)
        {
            try
            {
                var produtoDTO = _produtoReadOnly.BuscarProduto(produto._id);
                if (produtoDTO._id > 0)
                {
                    return BadRequest();
                }
                _produtoService.CriarProduto(produto);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Produto/AlterarProduto")]
        [HttpPut]
        public IHttpActionResult AlterarProduto(ProdutoDTO produto)
        {
            try
            {
                _produtoService.AlterarProduto(produto);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }

        [Route("api/Produto/RemoverProduto/{id}")]
        [HttpDelete]
        public IHttpActionResult RemoverProduto(int id)
        {
            try
            {
                var produtoDTO = _produtoReadOnly.BuscarProduto(id);
                if (produtoDTO._id == 0)
                {
                    return NotFound();
                }
                _produtoService.RemoverProduto(produtoDTO);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Ok();
        }
    }
}
