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
            RadControl.EnableDpiScaling = false;
            InitializeComponent();
            this.container = container;
            this.clienteAcces = clienteAcces;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            radDock1.AutoDetectMdiChildren = true;

        }


        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = container.GetInstance<FrmCliente>();
            if (frmCliente.IsDisposed)
            {
                frmCliente = new FrmCliente(clienteAcces, container);
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

            frmImportador.MdiParent = this;
            frmImportador.Show();

        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            FrmConvertidorXmlAExcel frmConvertidor = container.GetInstance<FrmConvertidorXmlAExcel>();
            if (frmConvertidor.IsDisposed)
            {
                frmConvertidor = new FrmConvertidorXmlAExcel();
            }

            frmConvertidor.MdiParent = this;
            frmConvertidor.Show();
        }
    }
}
