using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            Property(e => e.logradouro)
                .IsUnicode(false);

            Property(e => e.complemento)
                .IsUnicode(false);

            Property(e => e.bairro)
                .IsUnicode(false);

            Property(e => e.cidade)
                .IsUnicode(false);

            Property(e => e.estado)
                .IsUnicode(false);
        }
    }
}
