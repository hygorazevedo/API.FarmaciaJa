using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(p => p._id);
            Property(p => p._id);
            Property(p => p.logradouro);
            Property(p => p.numero);
            Property(p => p.complemento);
            Property(p => p.bairro);
            Property(p => p.cidade);
            Property(p => p.Estado);

            ToTable("endereco");
        }
    }
}
