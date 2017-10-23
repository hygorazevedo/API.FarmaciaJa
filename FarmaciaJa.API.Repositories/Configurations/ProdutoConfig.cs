using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            Property(e => e.descProduto);

            Property(e => e.nomeProduto);

            Property(e => e.valorProduto);
        }
    }
}
