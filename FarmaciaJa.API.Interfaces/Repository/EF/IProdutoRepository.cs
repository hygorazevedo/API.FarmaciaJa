using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Interfaces.Repository.EF
{
    public interface IProdutoRepository
    {
        void CriarProduto(ProdutoDTO produtoDTO);
        void AlterarProduto(ProdutoDTO produtoDTO);
        void RemoverProduto(ProdutoDTO produtoDTO);
    }
}
