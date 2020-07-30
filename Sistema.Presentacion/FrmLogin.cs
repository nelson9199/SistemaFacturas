using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Sistema.Presentacion
{
    public partial class FrmLogin : RadForm
    {
        private readonly IUsuarioAccessRepo<Usuario> usuarioAccess;
        private readonly SimpleInjector.Container container;
        private FrmLoading2 loading = null;

        public FrmLogin(IUsuarioAccessRepo<Usuario> usuarioAccess, SimpleInjector.Container container)
        {
            InitializeComponent();
            this.usuarioAccess = usuarioAccess;
            this.container = container;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowLoading()
        {
            loading = new FrmLoading2(); ;
            loading.Show();
        }

        private void HideLoanding()
        {
            if (loading != null)
            {
                loading.Dispose();
            }
        }

        private void AsignarRoles(string username, string rol)
        {
            var identity = new GenericIdentity(username, "Auth");
            var principal = new GenericPrincipal(identity, new string[] { rol });
            System.Threading.Thread.CurrentPrincipal = principal;
        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoading();
                (Usuario usuario, string respuesta) = await usuarioAccess.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim());
                HideLoanding();
                if (respuesta == "No existe")
                {
                    MessageBox.Show("No existe el Usuario. Ingrese las credenciales correctamente", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (respuesta == "clave Wrong")
                {
                    MessageBox.Show("La contraseña fue incorrecta porfavor intente con otra", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (respuesta == "Inicion de Sesión Exitoso")
                {
                    if (usuario.Estado == false)
                    {
                        MessageBox.Show("Este usuario no esta activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        AsignarRoles(txtUsuario.Text, usuario.Rol.Nombre);

                        FrmPrincipal frmPrincipal = container.GetInstance<FrmPrincipal>();
                        frmPrincipal.IdUsuario = usuario.UsuarioId;
                        frmPrincipal.IdRol = usuario.RolId;
                        frmPrincipal.Rol = usuario.Rol.Nombre;
                        frmPrincipal.Nombre = usuario.Nombre;
                        frmPrincipal.Estado = usuario.Estado;

                        frmPrincipal.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
