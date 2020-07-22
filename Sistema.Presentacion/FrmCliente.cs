using Sistema.Entidades;
using Sistema.Negocio.ClienteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Telerik.WinControls.UI.RadTabbedForm
    {

        private FrmLoading1 loading = null;
        private readonly IClienteAccesRepo<Cliente> clienteAcces;
        private readonly SimpleInjector.Container container;

        public FrmCliente(IClienteAccesRepo<Cliente> clienteAcces, SimpleInjector.Container container)
        {
            InitializeComponent();

            this.AllowAero = false;
            this.clienteAcces = clienteAcces;
            this.container = container;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task Listar()
        {
            try
            {
                gridClientes.DataSource = await clienteAcces.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ShowLoading()
        {
            loading = new FrmLoading1();
            loading.Show();
            loading.BringToFront();
        }

        private void HideLoanding()
        {
            if (loading != null)
            {
                loading.Close();
            }
        }

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            ShowLoading();
            await Listar();
            HideLoanding();
        }
    }
}
