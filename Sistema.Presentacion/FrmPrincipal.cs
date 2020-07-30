using Sistema.Entidades;
using Sistema.Negocio.ClienteFacturaLogic;
using Sistema.Negocio.ClienteLogic;
using Sistema.Negocio.FacturaLogic;
using Sistema.Presentacion.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Telerik.WinControls.UI.RadForm
    {
        private readonly SimpleInjector.Container container;
        private readonly IFormOpener formOpener;

        public int IdUsuario { get; set; }
        public int? IdRol { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }

        public FrmPrincipal(SimpleInjector.Container container, IFormOpener formOpener)
        {
            RadControl.EnableDpiScaling = false;
            InitializeComponent();
            this.container = container;
            this.formOpener = formOpener;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult option;
            option = MessageBox.Show("¿Desea salir del sistema?", "Sistema de gestión de Facturas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (option == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
