using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Estado)
                 .HasConversion(Convertidores.ObtenerBoolToStringConverter("inactivo", "activo"));

            builder.Property(X => X.Estado)
                .HasDefaultValue(true);

            builder.HasOne(x => x.Rol)
                .WithMany(x => x.Usuarios)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
