using FarmaciaJa.API.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FarmaciaJa.API.Repositories.Configurations
{
    public class FarmaciaConfig : EntityTypeConfiguration<Farmacia>
    {
        public FarmaciaConfig()
        {
            Property(e => e.descFarmacia)
                .IsUnicode(false);

            Property(e => e.endereco)
                .IsUnicode(false);

            Property(e => e.informacoesFarmacia)
                .IsUnicode(false);
        }
    }
}
