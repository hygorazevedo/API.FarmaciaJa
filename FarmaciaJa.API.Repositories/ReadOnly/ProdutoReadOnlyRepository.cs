using System.Collections.Generic;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Repositories.Contexts;
using Dapper;

namespace FarmaciaJa.API.Repositories.ReadOnly
{
    public class ProdutoReadOnlyRepository : IProdutoReadOnlyRepository
    {
        private FarmaciaJaContext _contexto;

        public List<ProdutoDTO> ListarProdutos()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            using (_contexto = new FarmaciaJaContext())
            {
                string query = @"select *
                                 from farmaciaja..produto p";
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    produtos.Add(new ProdutoDTO
                    {
                        _id = item._id,
                        farmacia_id = item.farmacia_id,
                        descProduto = item.descProduto,
                        nomeProduto = item.nomeProduto,
                        valorProduto = item.valorProduto
                    });
                }
            }
            return produtos;
        }

        public ProdutoDTO BuscarProduto(int id)
        {
            ProdutoDTO produto = new ProdutoDTO();
            string query = $@"select *
                              from farmaciaja..produto p
                              where p._id = {id}";

            using (_contexto = new FarmaciaJaContext())
            {
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    produto._id = item._id;
                    produto.farmacia_id = item.farmacia_id;
                    produto.descProduto = item.descProduto;
                    produto.nomeProduto = item.nomeProduto;
                    produto.valorProduto = item.valorProduto;
                }
            }
            return produto;
        }
    }
}
