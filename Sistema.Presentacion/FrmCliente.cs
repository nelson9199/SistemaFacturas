using Sistema.Datos.Helpers;
using Sistema.Entidades;
using Sistema.Negocio.ClienteFacturaLogic;
using Sistema.Negocio.ClienteLogic;
using Sistema.Negocio.FacturaLogic;
using Sistema.Presentacion.Helpers;
using Sistema.Presentacion.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : RadTabbedForm
    {
        private string numDocAnt = string.Empty;
        private string numRucAnt = string.Empty;
        private FrmLoading1 loading = null;
        private readonly IClienteAccesRepo<Cliente> clienteAcces;
        private readonly SimpleInjector.Container container;
        private readonly IFormOpener formOpener;
        private readonly IClienteFacturaAccesRepo clienteFacturaAcces;
        private readonly IFacturaAccesRepo<Factura> facturaAccesRepo;
        private AppConfigReaderP appConfigReader = AppConfigReaderP.ObtenerInstancia();
        private string directorio;

        public FrmCliente(IClienteAccesRepo<Cliente> clienteAcces, SimpleInjector.Container container, IFormOpener formOpener, IClienteFacturaAccesRepo clienteFacturaAcces, IFacturaAccesRepo<Factura> facturaAccesRepo)
        {
            InitializeComponent();
            this.AllowAero = false;
            this.clienteAcces = clienteAcces;
            this.container = container;
            this.formOpener = formOpener;
            this.clienteFacturaAcces = clienteFacturaAcces;
            this.facturaAccesRepo = facturaAccesRepo;
            directorio = appConfigReader.ObtenerAppSettingsValue("FacturaFolder");
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
                gridClientes.DataSource = await clienteAcces.Listar();
                lblTotal.Text = "Total registros: " + gridClientes.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void EstilosGridView()
        {
            gridClientes.AllowCellContextMenu = false;
            gridClientes.EnableFiltering = false;
            gridClientes.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            gridClientes.Columns[0].Width = 100;
            gridClientes.Columns[0].AllowFiltering = false;

            gridClientes.Columns[1].IsVisible = false;

            gridClientes.Columns[2].Width = 200;
            gridClientes.Columns[2].HeaderText = "Primer Nombre";
            gridClientes.Columns[2].ReadOnly = true;
            gridClientes.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[3].Width = 200;
            gridClientes.Columns[3].HeaderText = "Segundo Nombre";
            gridClientes.Columns[3].ReadOnly = true;
            gridClientes.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[4].Width = 200;
            gridClientes.Columns[4].HeaderText = "Primer Apellido";
            gridClientes.Columns[4].ReadOnly = true;
            gridClientes.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[5].Width = 200;
            gridClientes.Columns[5].HeaderText = "Segundo Apellido";
            gridClientes.Columns[5].ReadOnly = true;
            gridClientes.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[6].Width = 200;
            gridClientes.Columns[6].HeaderText = "Tipo Documento";
            gridClientes.Columns[6].ReadOnly = true;
            gridClientes.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[7].Width = 200;
            gridClientes.Columns[7].HeaderText = "Número de Documento";
            gridClientes.Columns[7].ReadOnly = true;
            gridClientes.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[8].Width = 200;
            gridClientes.Columns[8].HeaderText = "RUC";
            gridClientes.Columns[8].ReadOnly = true;
            gridClientes.Columns[8].TextAlignment = ContentAlignment.MiddleCenter;

            gridClientes.Columns[9].Width = 100;
            gridClientes.Columns[9].HeaderText = "Estado";
            gridClientes.Columns[9].ReadOnly = true;

            gridClientes.Columns[10].IsVisible = false;

            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtDoc.Clear();
            txtPasaporte.Clear();
            txtPrimerApellido.Clear();
            txtPrimerNombre.Clear();
            txtSegundoApellido.Clear();
            txtSegundoNombre.Clear();
            txtRuc.Clear();

            btnInsertar.Visible = true;
            btnActualizar.Visible = false;
            btnFacturas.Visible = false;
            gridClientes.Columns[0].IsVisible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;
            txtPasaporte.Visible = false;
            txtDoc.Visible = true;
        }

        private Cliente ObtenerDatosCliente()
        {
            Cliente cliente = container.GetInstance<Cliente>();

            cliente.PrimerNombre = txtPrimerNombre.Text.Trim();
            cliente.SegundoNombre = txtSegundoNombre.Text.Trim();
            cliente.PrimerApellido = txtPrimerApellido.Text.Trim();
            cliente.SegundoApellido = txtSegundoApellido.Text.Trim();
            cliente.TipoDocumento = dropTipoDocu.Text.Trim();

            if (txtDoc.Visible == true)
            {
                cliente.NumeroDocumento = txtDoc.Text.Trim();
            }
            else if (txtPasaporte.Visible == true)
            {
                cliente.NumeroDocumento = txtPasaporte.Text.Trim();
            }

            cliente.RUC = txtRuc.Text.Trim();

            return cliente;
        }

        private List<bool> ValidarCampos()
        {
            List<bool> validaciones = new List<bool>();

            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.radTabbedFormControlTab2.Controls)
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

        private async void FrmCliente_Load(object sender, EventArgs e)
        {

            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;

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
                gridClientes.EnableFiltering = true;
            }
            else
            {
                gridClientes.EnableFiltering = false;
            }
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

                    respuesta = await clienteAcces.Insertar(ObtenerDatosCliente());

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            radTabbedFormControl1.SelectedTab = radTabbedFormControlTab1;
        }

        private void chkSeleccionar_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chkSeleccionar.Checked)
            {
                gridClientes.Columns[0].IsVisible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                gridClientes.Columns[0].IsVisible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void dropTipoDocu_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (dropTipoDocu.SelectedIndex == 2)
            {
                txtPasaporte.Visible = true;
                txtDoc.Visible = false;
                radValidationProvider1.SetValidationRule(txtPasaporte, radValidationProvider1.ValidationRules[0]);
                radValidationProvider1.RemoveControlFromRules(txtDoc);
            }
            else if (dropTipoDocu.SelectedIndex == 1)
            {
                txtPasaporte.Visible = false;
                txtDoc.Visible = true;
                radValidationProvider1.RemoveControlFromRules(txtPasaporte);
                radValidationProvider1.SetValidationRule(txtDoc, radValidationProvider1.ValidationRules[0]);
                radValidationProvider1.SetValidationRule(txtDoc, radValidationProvider1.ValidationRules[3]);
            }
        }

        private void gridClientes_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                btnFacturas.Visible = true;

                txtId.Text = gridClientes.CurrentRow.Cells["ClienteId"].Value?.ToString();
                dropTipoDocu.Text = gridClientes.CurrentRow.Cells["TipoDocumento"].Value?.ToString();

                if (dropTipoDocu.Text.Trim().Equals("Pasaporte"))
                {
                    txtPasaporte.Visible = true;
                    txtDoc.Visible = false;

                    txtPasaporte.Text = gridClientes.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();
                    numDocAnt = gridClientes.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();

                    radValidationProvider1.SetValidationRule(txtPasaporte, radValidationProvider1.ValidationRules[0]);
                    radValidationProvider1.RemoveControlFromRules(txtDoc);
                }
                else if (dropTipoDocu.Text.Trim().Equals("Cédula"))
                {
                    radValidationProvider1.RemoveControlFromRules(txtPasaporte);
                    radValidationProvider1.SetValidationRule(txtDoc, radValidationProvider1.ValidationRules[0]);
                    radValidationProvider1.SetValidationRule(txtDoc, radValidationProvider1.ValidationRules[3]);

                    txtDoc.Text = gridClientes.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();
                    numDocAnt = gridClientes.CurrentRow.Cells["NumeroDocumento"].Value?.ToString();

                    txtPasaporte.Visible = false;
                    txtDoc.Visible = true;
                }
                txtPrimerApellido.Text = gridClientes.CurrentRow.Cells["PrimerApellido"].Value?.ToString();
                txtSegundoApellido.Text = gridClientes.CurrentRow.Cells["SegundoApellido"].Value?.ToString();
                txtPrimerNombre.Text = gridClientes.CurrentRow.Cells["PrimerNombre"].Value?.ToString();
                txtSegundoNombre.Text = gridClientes.CurrentRow.Cells["SegundoNombre"].Value?.ToString();
                txtRuc.Text = gridClientes.CurrentRow.Cells["RUC"].Value?.ToString();
                numRucAnt = gridClientes.CurrentRow.Cells["RUC"].Value?.ToString();

                radTabbedFormControl1.SelectedTab = radTabbedFormControlTab2;

            }
            catch
            {
                MessageBox.Show("No hay ningún registro que selecionar"); ;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
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

                    var clienteUpdate = ObtenerDatosCliente();

                    clienteUpdate.ClienteId = Convert.ToInt32(txtId.Text);

                    respuesta = await clienteAcces.Actualizar(clienteUpdate, numDocAnt, numRucAnt);

                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Se actualizó de forma correcta el registro");
                        Limpiar();
                        await Listar();
                        radTabbedFormControl1.SelectedTab = radTabbedFormControlTab1;
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
                    int clienteId;
                    string respuesta;

                    foreach (var fila in gridClientes.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            clienteId = Convert.ToInt32(fila.Cells[1].Value);

                            var facturaCliente = await clienteFacturaAcces.Listar(clienteId);

                            foreach (var item in facturaCliente)
                            {
                                var facturaAEliminar = await facturaAccesRepo.ObtenerFacturaPorId(item.FacturaId);
                                File.Delete(Path.Combine(directorio, facturaAEliminar.ArchivoFactura));
                                await facturaAccesRepo.Eliminar(item.FacturaId);
                            }

                            respuesta = await clienteAcces.Eliminar(clienteId);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se elimino el cliente con documento de indentificación: " + fila.Cells[8].Value?.ToString());
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
                    int clienteId;
                    string respuesta;

                    foreach (var fila in gridClientes.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            clienteId = Convert.ToInt32(fila.Cells[1].Value);

                            respuesta = await clienteAcces.Activar(clienteId);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se Activo el cliente con documento de identificación: " + fila.Cells[7].Value?.ToString());
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
                    int clienteId;
                    string respuesta;

                    foreach (var fila in gridClientes.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            clienteId = Convert.ToInt32(fila.Cells[1].Value);

                            respuesta = await clienteAcces.Desactivar(clienteId);

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se Desactivo el cliente con documento de identificación: " + fila.Cells[7].Value?.ToString());
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

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            using (var form = container.GetInstance<FrmFacturaCliente1>())
            {
                form.ClienteId = Convert.ToInt32(txtId.Text);
                form.NombreCliente = txtPrimerNombre.Text + " " + txtPrimerApellido.Text;
                form.ShowDialog();
            }
        }

        private void radTabbedFormControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            if (radTabbedFormControl1.SelectedTab == radTabbedFormControlTab1)
            {
                Limpiar();
            }
        }

        private void gridClientes_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

