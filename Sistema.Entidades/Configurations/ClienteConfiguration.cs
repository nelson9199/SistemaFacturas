using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasQueryFilter(x => x.EstaBorrado == false);

            builder.Property(x => x.EstaBorrado)
                .HasDefaultValue(false);

            builder.HasIndex(x => x.NumeroDocumento)
                .IsUnique(true);

            builder.HasIndex(x => x.RUC)
                .IsUnique(true);

            builder.Property(x => x.Estado)
                .HasConversion(Convertidores.ObtenerBoolToStringConverter("inactivo", "activo"));

            builder.Property(x => x.Estado)
                .HasDefaultValue(true);

            var cliente1 = new Cliente()
            {
                ClienteId = 1,
                PrimerNombre = "Nelson",
                PrimerApellido = "Marro",
                TipoDocumento = "Cedula",
                NumeroDocumento = "1757078579",
                RUC = "1757078579001"
            };

            var cliente2 = new Cliente()
            {
                ClienteId = 2,
                PrimerNombre = "Maria",
                PrimerApellido = "Pacheco",
                TipoDocumento = "Cedula",
                NumeroDocumento = "1757078578",
                RUC = "1757078579002"
            };

            builder.HasData(cliente1, cliente2);
        }
    }
}
