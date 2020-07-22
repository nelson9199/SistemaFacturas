using Sistema.Entidades;
using Sistema.Negocio.ClienteLogic;
using Sistema.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

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

        private async Task Listar()
        {
            try
            {
                gridClientes.DataSource = await clienteAcces.Listar();
                lblTotal.Text = "Total reistros: " + gridClientes.RowCount.ToString();
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
            gridClientes.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

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
            gridClientes.Columns[9].AllowFiltering = false;

            gridClientes.Columns[10].IsVisible = false;

            gridClientes.Columns[11].IsVisible = false;

            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtDoc.Clear();
            txtPrimerApellido.Clear();
            txtPrimerNombre.Clear();
            txtSegundoApellido.Clear();
            txtSegundoNombre.Clear();
            txtRuc.Clear();
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;

            gridClientes.Columns[0].IsVisible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;
        }

        private Cliente ObtenerDatosCliente()
        {
            Cliente cliente = container.GetInstance<Cliente>();

            cliente.PrimerNombre = txtPrimerNombre.Text;
            cliente.SegundoNombre = txtSegundoNombre.Text;
            cliente.PrimerApellido = txtPrimerApellido.Text;
            cliente.SegundoApellido = txtSegundoApellido.Text;
            cliente.TipoDocumento = dropTipoDocu.Text;
            cliente.NumeroDocumento = txtDoc.Text;
            cliente.RUC = txtRuc.Text;

            return cliente;
        }

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
            #region LayoutControlConfigurations     
            layoutControlItem1.AllowDelete = false;
            layoutControlItem1.AllowDrag = false;
            layoutControlItem1.AllowDrop = false;
            layoutControlItem1.AllowHide = false;

            layoutControlItem2.AllowDelete = false;
            layoutControlItem2.AllowDrag = false;
            layoutControlItem2.AllowDrop = false;
            layoutControlItem2.AllowHide = false;
            #endregion

            radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;

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

        private void txtRuc_TextChanging(object sender, TextChangingEventArgs e)
        {
            e.Cancel = !IsNumber(e.NewValue);
        }

        private void txtNumDocu_TextChanging(object sender, TextChangingEventArgs e)
        {
            e.Cancel = !IsNumber(e.NewValue);
        }

        private void radTabbedFormControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            if (radTabbedFormControl1.SelectedTab == radTabbedFormControlTab1)
            {
                radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.None;
            }
            if (radTabbedFormControl1.SelectedTab == radTabbedFormControlTab2)
            {
                radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            }
        }
    }
}
