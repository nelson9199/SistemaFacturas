using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Configurations
{
    public class ClienteFacturaConfiguration : IEntityTypeConfiguration<ClienteFacturas>
    {
        public void Configure(EntityTypeBuilder<ClienteFacturas> builder)
        {
            builder.HasKey(x => new { x.ClienteId, x.FacturaId });

            builder.HasIndex(x => x.FacturaId)
                .IsUnique(true);

        }
    }
}
