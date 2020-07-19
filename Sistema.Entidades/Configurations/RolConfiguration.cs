using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Configurations
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.Property(x => x.Estado)
                .HasConversion(Convertidores.ObtenerBoolToStringConverter("inactivo", "activo"));

            builder.Property(X => X.Estado)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Nombre)
                .IsUnique(true);
        }
    }
}
