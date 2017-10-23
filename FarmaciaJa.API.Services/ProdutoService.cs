using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Interfaces.Service;

namespace FarmaciaJa.API.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void CriarProduto(ProdutoDTO produtoDTO)
        {
            _produtoRepository.CriarProduto(produtoDTO);
        }

        public void AlterarProduto(ProdutoDTO produtoDTO)
        {
            _produtoRepository.AlterarProduto(produtoDTO);
        }

        public void RemoverProduto(ProdutoDTO produtoDTO)
        {
            _produtoRepository.RemoverProduto(produtoDTO);
        }
    }
}
