using SimpleInjector;
using Sistema.Datos.ClienteRepository;
using Sistema.Datos.Services;
using Sistema.Entidades;
using Sistema.Negocio.ClienteLogic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<FrmPrincipal>());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<FrmPrincipal>(Lifestyle.Singleton);
            container.Register<FrmCliente>(Lifestyle.Singleton);
            container.Register<FrmImportadorAPlantilla>(Lifestyle.Singleton);
            container.Register<IMapperProvider, MapperProvider>(Lifestyle.Singleton);
            container.Register<IClienteRepository<Cliente>, ClienteRepository>(Lifestyle.Singleton);
            container.Register<IClienteAccesRepo<Cliente>, NCliente>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
