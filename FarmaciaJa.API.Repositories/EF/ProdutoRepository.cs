using AutoMapper;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Repositories.Contexts;
using System.Data.Entity;

namespace FarmaciaJa.API.Repositories.EF
{
    public class ProdutoRepository : IProdutoRepository
    {
        private FarmaciaJaContext _contexto;

        public void CriarProduto(ProdutoDTO produtoDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Produtos.Add(Mapper.Map<Produto>(produtoDTO));
                _contexto.SaveChanges();
            }
        }

        public void AlterarProduto(ProdutoDTO produtoDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Produto>(produtoDTO)).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
        }

        public void RemoverProduto(ProdutoDTO produtoDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Produto>(produtoDTO)).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
        }
    }
}
