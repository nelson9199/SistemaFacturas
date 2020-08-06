using Sistema.Entidades;
using Sistema.Negocio._UsuarioLogic;
using Sistema.Negocio.RolLogic;
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
        private readonly SimpleInjector.Container container;
        private readonly IRolAccessRepo rolAccess;
        private string numDocAnt;
        private string emailAnt;

        public FrmUsuario(IUsuarioAccessRepo<Usuario> usuarioAccess, SimpleInjector.Container container, IRolAccessRepo rolAccess)
        {
            InitializeComponent();

            this.AllowAero = false;
            this.usuarioAccess = usuarioAccess;
            this.container = container;
            this.rolAccess = rolAccess;
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
                    usuario.Username,
                    usuario.Direccion,
                    usuario.Telefono,
                    usuario.Estado
                });

                lblTotal.Text = "Total registros: " + gridUsuarios.RowCount.ToString();

                if (gridUsuarios.ColumnCount > 1)
                {
                    EstilosGridView();
                }
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

                gridUsuarios.Columns[3].Width = 200;
                gridUsuarios.Columns[3].HeaderText = "Rol";
                gridUsuarios.Columns[3].ReadOnly = true;
                gridUsuarios.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[4].Width = 200;
                gridUsuarios.Columns[4].HeaderText = "Nombre";
                gridUsuarios.Columns[4].ReadOnly = true;
                gridUsuarios.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[5].Width = 200;
                gridUsuarios.Columns[5].HeaderText = "Tipo de Documento";
                gridUsuarios.Columns[5].ReadOnly = true;
                gridUsuarios.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[6].Width = 200;
                gridUsuarios.Columns[6].HeaderText = "Número de Documento";
                gridUsuarios.Columns[6].ReadOnly = true;
                gridUsuarios.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[7].Width = 200;
                gridUsuarios.Columns[7].HeaderText = "Usuario";
                gridUsuarios.Columns[7].ReadOnly = true;
                gridUsuarios.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[8].Width = 300;
                gridUsuarios.Columns[8].HeaderText = "Dirección";
                gridUsuarios.Columns[8].ReadOnly = true;
                gridUsuarios.Columns[8].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[9].Width = 200;
                gridUsuarios.Columns[9].HeaderText = "Teléfono";
                gridUsuarios.Columns[9].ReadOnly = true;
                gridUsuarios.Columns[9].TextAlignment = ContentAlignment.MiddleCenter;

                gridUsuarios.Columns[10].Width = 100;
                gridUsuarios.Columns[10].HeaderText = "Estado";
                gridUsuarios.Columns[10].ReadOnly = true;
                gridUsuarios.Columns[10].TextAlignment = ContentAlignment.MiddleCenter;
            }

            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();
            txtNumDoc.Clear();
            txtTelefono.Clear();
            txtPasaporte.Clear();
            txtUserId.Clear();

            gridUsuarios.Columns[0].IsVisible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;

            btnInsertar.Visible = true;
            btnActualizar.Visible = false;

            txtPasaporte.Visible = false;
            txtNumDoc.Visible = true;
        }

        private Usuario ObtenerDatosUsuarios()
        {
            Usuario usuario = container.GetInstance<Usuario>();

            usuario.Clave = txtClave.Text.Trim();
            usuario.Direccion = txtDireccion.Text.Trim();
            usuario.Username = txtUsuario.Text.Trim();
            usuario.Nombre = txtNombre.Text.Trim();
            usuario.RolId = Convert.ToInt32(dropRoles.SelectedValue);
            usuario.Telefono = txtTelefono.Text.Trim();
            usuario.TipoDocumento = dropTipoDocu.Text.Trim();

            if (txtNumDoc.Visible == true)
            {
                usuario.NumeroDocumento = txtNumDoc.Text.Trim();
            }
            else if (txtPasaporte.Visible == true)
            {
                usuario.NumeroDocumento = txtPasaporte.Text.Trim();
            }

            return usuario;
        }

        private List<bool> ValidarCampos()
        {
            List<bool> validaciones = new List<bool>();

            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.radPanel1.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        var resulValidacion = this.radValidationProvider1.Validate(editorControl);

                        validaciones.Add(resulValidacion);
                    }
                }

                foreach (Control control in this.radGroupBox1.Controls)
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

        private async void CargarRol()
        {
            try
            {
                dropRoles.DataSource = await rolAccess.Listar();
                dropRoles.ValueMember = "RolId";
                dropRoles.DisplayMember = "Nombre";
                RadListDataItem seleccionar = new RadListDataItem();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;

            Limpiar();

            ShowLoading();
            await Listar();
            HideLoanding();

            EstilosGridView();

            CargarRol();
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

        private void dropTipoDocu_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (dropTipoDocu.SelectedIndex == 2)
            {
                txtPasaporte.Visible = true;
                txtNumDoc.Visible = false;
                radValidationProvider1.SetValidationRule(txtPasaporte, radValidationProvider1.ValidationRules[0]);
                radValidationProvider1.RemoveControlFromRules(txtNumDoc);
            }
            else if (dropTipoDocu.SelectedIndex == 1)
            {
                txtPasaporte.Visible = false;
                txtNumDoc.Visible = true;
                radValidationProvider1.RemoveControlFromRules(txtPasaporte);
                radValidationProvider1.SetValidationRule(txtNumDoc, radValidationProvider1.ValidationRules[0]);
                radValidationProvider1.SetValidationRule(txtNumDoc, radValidationProvider1.ValidationRules[2]);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tabForm.SelectedTab = tabListado;
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                radValidationProvider1.SetValidationRule(txtClave, radValidationProvider1.ValidationRules[0]);

                var validaciones = ValidarCampos();

                if (validaciones.Contains(false))
                {
                    return;
                }
                else
                {
                    string respuesta = string.Empty;

                    respuesta = await usuarioAccess.Insertar(ObtenerDatosUsuarios());

                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Se insertó de forma correcta el registro");
                        Limpiar();
                        await Listar();
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

        private void gridUsuarios_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;

                txtUserId.Text = gridUsuarios.CurrentRow.Cells["UsuarioId"].Value?.ToString();

                dropRoles.SelectedValue = Convert.ToInt32(gridUsuarios.CurrentRow.Cells["RolId"].Value);

                txtNombre.Text = gridUsuarios.CurrentRow.Cells["Nombre"].Value?.ToString();

                dropTipoDocu.Text = gridUsuarios.CurrentRow.Cells["TipoDocumento"].Value?.ToString();

                txtDireccion.Text = gridUsuarios.CurrentRow.Cells["Direccion"].Value?.ToString();

                txtUsuario.Text = gridUsuarios.CurrentRow.Cells["Username"].Value?.ToString();
                emailAnt = gridUsuarios.CurrentRow.Cells["Username"].Value?.ToString();

                txtTelefono.Text = gridUsuarios.CurrentRow.Cells["Telefono"].Value?.ToString();

                if (dropTipoDocu.Text.Trim().Equals("Pasaporte"))
                {
                    txtPasaporte.Visible = true;
                    txtNumDoc.Visible = false;

                    txtPasaporte.Text = gridUsuarios.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();
                    numDocAnt = gridUsuarios.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();

                    radValidationProvider1.SetValidationRule(txtPasaporte, radValidationProvider1.ValidationRules[0]);
                    radValidationProvider1.RemoveControlFromRules(txtNumDoc);
                }
                else if (dropTipoDocu.Text.Trim().Equals("Cédula"))
                {
                    radValidationProvider1.RemoveControlFromRules(txtPasaporte);
                    radValidationProvider1.SetValidationRule(txtNumDoc, radValidationProvider1.ValidationRules[0]);
                    radValidationProvider1.SetValidationRule(txtNumDoc, radValidationProvider1.ValidationRules[2]);

                    txtNumDoc.Text = gridUsuarios.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();
                    numDocAnt = gridUsuarios.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();

                    txtPasaporte.Visible = false;
                    txtNumDoc.Visible = true;
                }

                tabForm.SelectedTab = tabMantenimiento;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                radValidationProvider1.RemoveControlFromRules(txtClave);

                var validaciones = ValidarCampos();

                if (validaciones.Contains(false))
                {
                    return;
                }
                else
                {
                    string respuesta = string.Empty;

                    var usuarioUpdate = ObtenerDatosUsuarios();

                    usuarioUpdate.UsuarioId = Convert.ToInt32(txtUserId.Text);

                    respuesta = await usuarioAccess.Actualizar(usuarioUpdate, numDocAnt, emailAnt);

                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Se actualizó de forma correcta el registro");
                        Limpiar();
                        await Listar();

                        tabForm.SelectedTab = tabListado;
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option;
                option = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    int usuarioId;
                    string nombreRol;
                    string respuesta;

                    foreach (var fila in gridUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            usuarioId = Convert.ToInt32(fila.Cells[2].Value);

                            nombreRol = fila.Cells[3].Value?.ToString();

                            respuesta = await usuarioAccess.Eliminar(usuarioId, nombreRol);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se eliminó el usuario con documento de indentificación: " + fila.Cells[6].Value?.ToString());
                            }
                            else
                            {
                                MensajeError(respuesta);
                            }
                        }
                    }
                    await Listar();
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }
        }

        private async void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option;
                option = MessageBox.Show("Realmente deseas activar el(los) registro(s)", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    int usuarioId;
                    string respuesta;

                    foreach (var fila in gridUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            usuarioId = Convert.ToInt32(fila.Cells[2].Value);

                            respuesta = await usuarioAccess.Activar(usuarioId);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se activó el usuario con documento de indentificación: " + fila.Cells[6].Value?.ToString());
                            }
                            else
                            {
                                MensajeError(respuesta);
                            }
                        }
                    }
                    await Listar();
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }
        }

        private async void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option;
                option = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    int usuarioId;
                    string respuesta;

                    foreach (var fila in gridUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            usuarioId = Convert.ToInt32(fila.Cells[2].Value);

                            respuesta = await usuarioAccess.Desactivar(usuarioId);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se desactivó el usuario con documento de indentificación: " + fila.Cells[6].Value?.ToString());
                            }
                            else
                            {
                                MensajeError(respuesta);
                            }
                        }
                    }
                    await Listar();
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }
        }

        private void tabForm_SelectedTabChanged(object sender, EventArgs e)
        {
            if (tabForm.SelectedTab == tabListado)
            {
                Limpiar();
            }
        }

        private void toggleFiltrar_ValueChanged(object sender, EventArgs e)
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

        private void gridUsuarios_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
