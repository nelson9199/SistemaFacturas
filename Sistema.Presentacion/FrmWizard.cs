using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using Sistema.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private bool usuarioEstaCreado = false;
        private bool yaEstaCerrado = false;

        public FrmWizard(IUsuarioAccessRepo<Usuario> usuarioAccessRepo, SimpleInjector.Container container)
        {
            InitializeComponent();
            this.usuarioAccessRepo = usuarioAccessRepo;
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


        private List<bool> ValidarCampos()
        {
            List<bool> validaciones = new List<bool>();

            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.panelUsuario.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        var resulValidacion = this.radValidationProvider1.Validate(editorControl);

                        validaciones.Add(resulValidacion);
                    }
                }
            }

            return validaciones;

        }

        private Usuario ObtenerDatosUsuarios()
        {
            Usuario usuario = container.GetInstance<Usuario>();

            usuario.Clave = txtClave.Text.Trim();
            usuario.Username = txtUsuario.Text.Trim();
            usuario.Nombre = txtNombre.Text.Trim();
            usuario.RolId = 1;
            usuario.TipoDocumento = dropTipoDocu.Text.Trim();
            usuario.NumeroDocumento = txtNumDoc.Text.Trim();

            return usuario;
        }

        private void SetValueToAppSettings<T>(string appsetingKey, T valueToAssing)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings[appsetingKey].Value = valueToAssing.ToString();
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var validaciones = ValidarCampos();

                if (validaciones.Contains(false))
                {
                    return;
                }
                else
                {
                    string respuesta = string.Empty;

                    respuesta = await usuarioAccessRepo.Insertar(ObtenerDatosUsuarios());

                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Se registró de forma correcta el Usuario");
                        usuarioEstaCreado = true;
                        radWizard1.SelectedPage = radWizard1.Pages[3];
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void FrmWizard_Load(object sender, EventArgs e)
        {
            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;

            RadWizardLocalizationProvider.CurrentProvider = new MyWizardLocalizationProvider();
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
            folderBrowserDialog1.SelectedPath = "";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderFac.Text = folderBrowserDialog1.SelectedPath;
                SetValueToAppSettings<string>("FacturaFolder", folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnFolderDbBak_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderDbBak.Text = folderBrowserDialog1.SelectedPath;

                SetValueToAppSettings<string>("DbBackupFolder", folderBrowserDialog1.SelectedPath);
            }
        }

        private void radWizard1_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if (e.SelectedPage == radWizard1.Pages[1])
            {
                if (txtFolderFac.Text == "" || txtFolderDbBak.Text == "")
                {
                    MessageBox.Show("Debe seleccionar las carpetas requeridas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.Cancel = true;
                }
            }
            else if (e.SelectedPage == radWizard1.Pages[2])
            {
                if (usuarioEstaCreado == false)
                {
                    MessageBox.Show("Debe crear un Usuario antes de continuar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.Cancel = true;
                }
            }
        }

        private void radWizard1_Finish(object sender, EventArgs e)
        {
            var option = MessageBox.Show("¿Está seguro de salvar las configuraciones ingresadas y continuar con el programa?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (option == DialogResult.OK)
            {
                MessageBox.Show("Configuariones Iniciales finalizadas con éxito. Ya esta listo para su primer inicion de sesión", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin login = container.GetInstance<FrmLogin>();

                login.Show();

                this.Hide();

                SetValueToAppSettings<bool>("WizardRunOnce", true);
            }
        }

        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            var option = MessageBox.Show("¿Está seguro de que quiere cerrar el programa?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (option == DialogResult.OK)
            {
                yaEstaCerrado = true;

                Application.Exit();
            }
        }

        private void FrmWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!yaEstaCerrado)
            {
                var option = MessageBox.Show("¿Está seguro de que quiere cerrar el programa?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
        }
    }
}
