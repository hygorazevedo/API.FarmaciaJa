namespace FarmaciaJa.API.Repositories.Contexts
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using FarmaciaJa.API.Repositories.Configurations;
    using FarmaciaJa.API.Domain;

    public partial class FarmaciaJaContext : DbContext
    {
        public FarmaciaJaContext()
            : base("name=FarmaciaJaContext")
        {
        }

        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Farmacia> Farmacias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FarmaciaJaContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FarmaciaConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }
    }
}
