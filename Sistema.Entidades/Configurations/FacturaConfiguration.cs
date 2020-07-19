using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Configurations
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasIndex(x => x.NumeroFactura)
                .IsUnique(true);

            builder.HasQueryFilter(x => x.EstaBorrado == false);

            builder.Property(x => x.EstaBorrado)
                .HasDefaultValue(false);

        }
    }
}
