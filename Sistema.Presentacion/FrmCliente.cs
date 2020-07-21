using Sistema.Entidades;
using Sistema.Negocio.ClienteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Telerik.WinControls.UI.RadTabbedForm
    {
        private static FrmCliente instancia = null;
        private readonly IClienteAccesRepo<Cliente> clienteAcces;

        public FrmCliente(IClienteAccesRepo<Cliente> clienteAcces)
        {
            InitializeComponent();

            this.AllowAero = false;
            this.clienteAcces = clienteAcces;
        }

        public FrmCliente InstaciaCliente { get; set; }

        public FrmCliente ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmCliente(clienteAcces);

            }
            return instancia;
        }

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void radTabbedFormControlTab1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
