using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using Sistema.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Sistema.Presentacion
{
    public partial class FrmUsuario : RadTabbedForm
    {
        private FrmLoading1 loading = null;
        private readonly IUsuarioAccessRepo<Usuario> usuarioAccess;

        public FrmUsuario(IUsuarioAccessRepo<Usuario> usuarioAccess)
        {
            InitializeComponent();

            this.AllowAero = false;
            this.usuarioAccess = usuarioAccess;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowLoading()
        {
            loading = new FrmLoading1(); ;
            loading.Show();
            loading.BringToFront();
        }

        private void HideLoanding()
        {
            if (loading != null)
            {
                loading.Dispose();
            }
        }

        private async Task Listar()
        {
            try
            {
                List<Usuario> usuariosConRol = await usuarioAccess.Listar();

                //Cuando hago proyecciones a tipos anonimos la creacion de cada propiedad del tipo anonimo depende de que se rellene con algun valor por lo tanto cuando lo asigno como data source del gridView si la proyeccion viene vacia no se crearán las columnas correspondientes a las propiedades del tipo anonimo por lo que debo hacer una comprobación para no obtener excepsiones por falta de columnas cuando valla a darle formato a estas en el método EstilosGridView
                gridUsuarios.DataSource = usuariosConRol.Select(usuario => new
                {
                    usuario.RolId,
                    usuario.UsuarioId,
                    Rol = usuario.Rol.Nombre,
                    usuario.Nombre,
                    usuario.TipoDocumento,
                    usuario.NumeroDocumento,
                    usuario.Email,
                    usuario.Direccion,
                    usuario.Telefono,
                    usuario.Estado
                });

                lblTotal.Text = "Total reistros: " + gridUsuarios.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void EstilosGridView()
        {
            gridUsuarios.AllowCellContextMenu = false;
            gridUsuarios.EnableFiltering = false;
            gridUsuarios.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            if (gridUsuarios.ColumnCount > 1)
            {
                gridUsuarios.Columns[0].Width = 100;
                gridUsuarios.Columns[0].AllowFiltering = false;

                gridUsuarios.Columns[1].IsVisible = false;

                gridUsuarios.Columns[2].IsVisible = false;

                gridUsuarios.Columns[2].Width = 200;
                gridUsuarios.Columns[2].HeaderText = "Rol";
                gridUsuarios.Columns[2].ReadOnly = true;
                gridUsuarios.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[3].Width = 200;
                gridUsuarios.Columns[3].HeaderText = "Nombre";
                gridUsuarios.Columns[3].ReadOnly = true;
                gridUsuarios.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[4].Width = 200;
                gridUsuarios.Columns[4].HeaderText = "Tipo de Documento";
                gridUsuarios.Columns[4].ReadOnly = true;
                gridUsuarios.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[5].Width = 200;
                gridUsuarios.Columns[5].HeaderText = "Número de Documento";
                gridUsuarios.Columns[5].ReadOnly = true;
                gridUsuarios.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[6].Width = 200;
                gridUsuarios.Columns[6].HeaderText = "Email";
                gridUsuarios.Columns[6].ReadOnly = true;
                gridUsuarios.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[7].Width = 300;
                gridUsuarios.Columns[7].HeaderText = "Dirección";
                gridUsuarios.Columns[7].ReadOnly = true;
                gridUsuarios.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[8].Width = 200;
                gridUsuarios.Columns[8].HeaderText = "Teléfono";
                gridUsuarios.Columns[8].ReadOnly = true;
                gridUsuarios.Columns[8].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[9].Width = 100;
                gridUsuarios.Columns[9].HeaderText = "Estado";
                gridUsuarios.Columns[9].ReadOnly = true;
                gridUsuarios.Columns[9].TextAlignment = ContentAlignment.MiddleCenter;
            }

            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private void Limpiar()
        {
            gridUsuarios.Columns[0].IsVisible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;
        }

        //private Cliente ObtenerDatosCliente()
        //{

        //}

        private bool IsNumber(string text)
        {
            bool res = true;
            try
            {
                if (!string.IsNullOrEmpty(text) && ((text.Length != 1) || (text != "-")))
                {
                    decimal d = decimal.Parse(text, CultureInfo.CurrentCulture);
                }
            }
            catch
            {
                res = false;
            }
            return res;
        }

        private List<bool> ValidarCampos()
        {
            List<bool> validaciones = new List<bool>();

            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.tabMantenimiento.Controls)
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

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            #region LayoutControlConfigurations    

            radLayoutControl1.AllowCustomize = false;

            #endregion

            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;

            txtEmail.MaskType = MaskType.EMail;

            Limpiar();

            ShowLoading();
            await Listar();
            HideLoanding();

            EstilosGridView();
        }

        private void radToggleSwitch1_ValueChanged(object sender, EventArgs e)
        {
            if (toggleFiltrar.Value == true)
            {
                gridUsuarios.EnableFiltering = true;
            }
            else
            {
                gridUsuarios.EnableFiltering = false;
            }
        }

        private void chkSeleccionar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkSeleccionar.Checked)
            {
                gridUsuarios.Columns[0].IsVisible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                gridUsuarios.Columns[0].IsVisible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

    }
}
