using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistema.Entidades.Configurations
{
    public class ClienteFacturaConfiguration : IEntityTypeConfiguration<ClienteFacturas>
    {
        public void Configure(EntityTypeBuilder<ClienteFacturas> builder)
        {
            builder.HasKey(x => new { x.ClienteId, x.FacturaId });

            builder.HasIndex(x => x.FacturaId)
                .IsUnique(true);

            builder.HasData(new ClienteFacturas() { ClienteId = 4, FacturaId = 1 });

        }
    }
}
