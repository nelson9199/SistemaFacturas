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

            builder.HasData(new Rol() { RolId = 1, Nombre = "Administrador", Descripcion = "Tiene Acceso a todas las funcionalidades del sistema" },
                            new Rol() { RolId = 2, Nombre = "Usuario Común", Descripcion = "Solo tiene acceso a lectura de datos y a las herramientas de conversión del sistema" });
        }
    }
}
