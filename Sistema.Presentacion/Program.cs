using SimpleInjector;
using Sistema.Datos.Repositories;
using Sistema.Datos.Services;
using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            container.Register<IMapperProvider, MapperProvider>();
            container.Register<ClienteRepository>();
            container.Register<NCliente>();

            // Optionally verify the container.
            container.Verify();
        }
    }
}
