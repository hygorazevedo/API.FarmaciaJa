using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Interfaces.Service
{
    public interface IProdutoService
    {
        void CriarProduto(ProdutoDTO produtoDTO);
        void AlterarProduto(ProdutoDTO produtoDTO);
        void RemoverProduto(ProdutoDTO produtoDTO);
    }
}
