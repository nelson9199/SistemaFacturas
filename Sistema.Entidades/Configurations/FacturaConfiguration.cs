using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Sistema.Entidades.Configurations
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasIndex(x => x.NumeroFactura)
                .IsUnique(true);

            builder.HasData(new Factura() { FacturaId = 1, ArchivoFactura = "archivo", FechaEmision = DateTime.Today, NumeroFactura = "001", Estado = "Por pagar" });
        }
    }
}
