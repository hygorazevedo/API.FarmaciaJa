using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            Property(e => e.nome);

            Property(e => e.email);

            Property(e => e.telefone);

            Property(e => e.usuario);

            Property(e => e.senha);

            HasOptional(e => e.endereco)
                .WithRequired(e => e.usuario);
        }
    }
}
