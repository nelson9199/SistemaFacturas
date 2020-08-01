using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using Sistema.Datos.Helpers;
using Sistema.Entidades;
using Sistema.Entidades.Configurations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class ApplicationDbContext : DbContext
    {
        private AppConfigReader connectionStringSettings;

        public ApplicationDbContext()
        {
            connectionStringSettings = AppConfigReader.ObtenerInstancia();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStringSettings["DefaultConnection"].ConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FacturaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteFacturaConfiguration());

        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteFacturas> ClienteFacturas { get; set; }
    }
}
