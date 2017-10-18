using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(p => p._id);
            Property(p => p.nome);
            Property(p => p.email);
            Property(p => p.telefone);
            Property(p => p.usuario);
            Property(p => p.senha);
            Property(p => p.logado);
            Property(p => p.logarAuto);

            ToTable("usuario");
        }
    }
}
