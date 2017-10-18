using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Repositories.Configurations;
using System.Data.Entity;

namespace FarmaciaJa.API.Repositories.Contexts
{
    public class FarmaciaJaContext : DbContext
    {
        public FarmaciaJaContext()
            : base("FarmaciaJaContext")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
        }
    }
}
