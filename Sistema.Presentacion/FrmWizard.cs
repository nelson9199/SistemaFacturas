using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Sistema.Presentacion
{
    public partial class FrmWizard : RadForm
    {
        private readonly IUsuarioAccessRepo<Usuario> usuarioAccessRepo;
        private readonly SimpleInjector.Container container;

        public FrmWizard(IUsuarioAccessRepo<Usuario> usuarioAccessRepo, SimpleInjector.Container container)
        {
            InitializeComponent();
            this.usuarioAccessRepo = usuarioAccessRepo;
            this.container = container;
        }

        private void FrmWizard_Load(object sender, EventArgs e)
        {
            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;
        }

        private void txtClave_MouseUp(object sender, MouseEventArgs e)
        {
            radButtonElement1.Image = Properties.Resources.ojo__1_;
            txtClave.PasswordChar = '*';
        }

        private void txtClave_MouseDown(object sender, MouseEventArgs e)
        {
            radButtonElement1.Image = Properties.Resources.esconder__1_;
            txtClave.PasswordChar = '\0';
        }

        private void btnCargarFac_Click(object sender, EventArgs e)
        {
            if (radOpenFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderFac.Text = radOpenFolderDialog1.FileName;
                FrmCliente.Directorio = radOpenFolderDialog1.FileName;
                FrmFacturaCliente1.Directorio = radOpenFolderDialog1.FileName;
            }
        }

        private void btnFolderDbBak_Click(object sender, EventArgs e)
        {
            if (radOpenFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderDbBak.Text = radOpenFolderDialog1.FileName;
            }
        }
    }
}
