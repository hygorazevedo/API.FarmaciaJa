using FarmaciaJa.API.Adapters.DTOs;
using System.Collections.Generic;

namespace FarmaciaJa.API.Interfaces.Repository.ReadOnly
{
    public interface IProdutoReadOnlyRepository
    {
        List<ProdutoDTO> ListarProdutos();
        ProdutoDTO BuscarProduto(int id);
    }
}
