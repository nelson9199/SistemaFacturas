using Sistema.Entidades;
using Sistema.Negocio.ClienteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Telerik.WinControls.UI.RadForm
    {
        private readonly SimpleInjector.Container container;
        private readonly IClienteAccesRepo<Cliente> clienteAcces;

        public FrmPrincipal(SimpleInjector.Container container, IClienteAccesRepo<Cliente> clienteAcces)
        {
            InitializeComponent();
            this.container = container;
            this.clienteAcces = clienteAcces;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            radDock1.AutoDetectMdiChildren = true;
            radDock1.MdiChildrenDockType = DockType.ToolWindow;
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = container.GetInstance<FrmCliente>();
            if (frmCliente.IsDisposed)
            {
                frmCliente = new FrmCliente(clienteAcces);
            }
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            FrmImportadorAPlantilla frmImportador = container.GetInstance<FrmImportadorAPlantilla>();
            if (frmImportador.IsDisposed)
            {
                frmImportador = new FrmImportadorAPlantilla();
            }
            frmImportador.Dock = DockStyle.None;
            frmImportador.MdiParent = this;
            frmImportador.Show();
        }
    }
}
