using Sistema.Datos.Services;
using Sistema.Presentacion.Helpers;
using Sistema.Presentacion.Services;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Telerik.WinControls.UI.RadForm
    {
        private readonly SimpleInjector.Container container;
        private readonly IFormOpener formOpener;
        private readonly IDataBaseBackupGenerator backupGenerator;
        private readonly ISqlConnectionProvider sqlConnectionProvider;
        private DialogResult option;
        private bool yaEstaCerrado;
        private static string DirectorioBackupDb;

        public int IdUsuario { get; set; }
        public int? IdRol { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public FrmPrincipal(SimpleInjector.Container container, IFormOpener formOpener, IDataBaseBackupGenerator backupGenerator, ISqlConnectionProvider sqlConnectionProvider)
        {
            RadControl.EnableDpiScaling = false;
            InitializeComponent();
            this.container = container;
            this.formOpener = formOpener;
            this.backupGenerator = backupGenerator;
            this.sqlConnectionProvider = sqlConnectionProvider;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CommandBarLocalizationProvider.CurrentProvider = new MySpanishCommandBarLocalizationProvider();

            this.WindowState = FormWindowState.Maximized;
            radDock1.AutoDetectMdiChildren = true;

            stLabelStatus.Text = "Desarrollado por X-Development, Usuario: " + this.Nombre;
            MessageBox.Show("Bienvenido: " + this.Nombre, "Sistema de Gestion de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                cBClientes.Enabled = true;
                menuItemAccesos.Enabled = true;
                menuItemCliente.Enabled = true;
            }
            else if (Thread.CurrentPrincipal.IsInRole("Usuario Común"))
            {
                cBClientes.Enabled = false;
                menuItemAccesos.Enabled = false;
                menuItemCliente.Enabled = false;
            }
        }


        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = formOpener.ShowModelessForm<FrmCliente>() as FrmCliente;
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            FrmImportadorAPlantilla frmImportador = formOpener.ShowModelessForm<FrmImportadorAPlantilla>() as FrmImportadorAPlantilla;

            frmImportador.MdiParent = this;
            frmImportador.Show();

        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            FrmConvertidorXmlAExcel frmConvertidor = formOpener.ShowModelessForm<FrmConvertidorXmlAExcel>() as FrmConvertidorXmlAExcel;

            frmConvertidor.MdiParent = this;
            frmConvertidor.Show();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            FrmRol frmRol = formOpener.ShowModelessForm<FrmRol>() as FrmRol;

            frmRol.MdiParent = this;
            frmRol.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = formOpener.ShowModelessForm<FrmUsuario>() as FrmUsuario;

            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            option = MessageBox.Show("¿Desea salir del sistema?", "Sistema de gestión de Facturas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (option == DialogResult.OK)
            {
                yaEstaCerrado = true;

                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            string databaseName = sqlConnectionProvider.ObtenerNombreDeLaDatabase();

            DirectorioBackupDb = ConfigurationManager.AppSettings["DbBackupFolder"];

            string backupQuery = $"BACKUP DATABASE [{databaseName}] TO  DISK = N'{DirectorioBackupDb}\\Backup_SistemaFacturas_{DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")}.bak' WITH NOFORMAT, NOINIT,  NAME = N'{databaseName}-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            string respuesta = backupGenerator.GenerarBackup(backupQuery);

            if (respuesta == "OK")
            {
                MessageBox.Show($"Copia de seguridad generada\n{DirectorioBackupDb}\\Backup_SistemaFacturas_{DateTime.Now.ToString("G")}\\.bak");
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Para evitar que se llame dos veces el metodo FormClosing debemos utilizar un condicional comprobando el CloseReason y dentro ejecutar la llamada al MessaBox de confirmacion para el Usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!yaEstaCerrado)
                {
                    option = MessageBox.Show("¿Desea salir del sistema?", "Sistema de gestión de Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (option == DialogResult.Yes)
                    {
                        try
                        {
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problemas al cerrar el programa. Error: " + ex.Message);
                        }

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }

        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            FrmImportadorAPlantilla frmImportador = formOpener.ShowModelessForm<FrmImportadorAPlantilla>() as FrmImportadorAPlantilla;

            frmImportador.MdiParent = this;
            frmImportador.Show();

        }

        private void commandBarButton4_Click(object sender, EventArgs e)
        {
            FrmConvertidorXmlAExcel frmConvertidor = formOpener.ShowModelessForm<FrmConvertidorXmlAExcel>() as FrmConvertidorXmlAExcel;

            frmConvertidor.MdiParent = this;
            frmConvertidor.Show();
        }

        private void cBClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = formOpener.ShowModelessForm<FrmCliente>() as FrmCliente;
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }
    }
}
