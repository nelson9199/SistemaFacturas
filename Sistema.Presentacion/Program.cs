using Microsoft.Data.SqlClient;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjector.Lifestyles;
using Sistema.Datos;
using Sistema.Datos._UsuariosRepository;
using Sistema.Datos.ClenteFacturaRepository;
using Sistema.Datos.ClienteRepository;
using Sistema.Datos.FacturaRepository;
using Sistema.Datos.RolRepository;
using Sistema.Datos.Services;
using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using Sistema.Negocio.ClienteFacturaLogic;
using Sistema.Negocio.ClienteLogic;
using Sistema.Negocio.FacturaLogic;
using Sistema.Negocio.RolLogic;
using Sistema.Presentacion.Services;
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
            Application.Run(container.GetInstance<FrmWizard>());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<FrmPrincipal>();
            container.Register<FrmCliente>();
            container.Register<FrmImportadorAPlantilla>();
            container.Register<FrmConvertidorXmlAExcel>();
            container.Register<FrmFacturaCliente1>();
            container.Register<FrmRol>();
            container.Register<FrmUsuario>();
            container.Register<FrmLogin>(Lifestyle.Singleton);
            container.Register<FrmWizard>(Lifestyle.Singleton);

            Registration registration1 = container.GetRegistration(typeof(FrmPrincipal)).Registration;

            registration1.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");
            Registration registration2 = container.GetRegistration(typeof(FrmCliente)).Registration;

            registration2.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");

            Registration registration3 = container.GetRegistration(typeof(FrmFacturaCliente1)).Registration;

            registration3.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");
            Registration registration4 = container.GetRegistration(typeof(FrmConvertidorXmlAExcel)).Registration;

            registration4.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");
            Registration registration5 = container.GetRegistration(typeof(FrmRol)).Registration;

            registration5.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");
            Registration registration6 = container.GetRegistration(typeof(FrmUsuario)).Registration;

            registration6.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");
            Registration registration7 = container.GetRegistration(typeof(FrmImportadorAPlantilla)).Registration;

            registration7.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "WindowsFroms needs");


            container.Register<IMapperProvider, MapperProvider>(Lifestyle.Singleton);

            container.Register<IProtector, Protector>(Lifestyle.Singleton);

            container.Register<ApplicationDbContext>(Lifestyle.Singleton);

            container.Register<IClienteRepository<Cliente>, ClienteRepository>(Lifestyle.Singleton);
            container.Register<IClienteAccesRepo<Cliente>, NCliente>(Lifestyle.Singleton);

            container.Register<IFacturaRepository<Factura>, FacturaRepository>(Lifestyle.Singleton);
            container.Register<IFacturaAccesRepo<Factura>, NFactura>(Lifestyle.Singleton);

            container.Register<IClienteFacturaRepository, ClienteFacturaRepository>(Lifestyle.Singleton);
            container.Register<IClienteFacturaAccesRepo, NClienteFactura>(Lifestyle.Singleton);

            container.Register<IRolRepository, RolRepository>(Lifestyle.Singleton);
            container.Register<IRolAccessRepo, NRol>(Lifestyle.Singleton);

            container.Register<IUsuarioRepository<Usuario>, UsuarioRepository>(Lifestyle.Singleton);
            container.Register<IUsuarioAccessRepo<Usuario>, NUsuario>(Lifestyle.Singleton);

            container.Register<Cliente>();
            container.Register<Factura>();
            container.Register<Rol>();
            container.Register<Usuario>();

            container.Register<IFormOpener, FormOpener>(Lifestyle.Singleton);
            container.Register<IDataBaseBackupGenerator, DatabaseBackupGenerator>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
