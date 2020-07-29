using Sistema.Entidades;
using Sistema.Negocio.ClienteFacturaLogic;
using Sistema.Negocio.FacturaLogic;
using Sistema.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

namespace Sistema.Presentacion
{
    public partial class FrmFacturaCliente1 : RadTabbedForm
    {
        private FrmLoading1 loading = null;
        private readonly IClienteFacturaAccesRepo clienteFacturaAcces;
        private readonly IFacturaAccesRepo<Factura> facturaAccesRepo;
        private readonly SimpleInjector.Container container;

        private string numFacAnt = "";
        private string rutaFacAnt = "";
        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "D:\\Facturas\\";

        public FrmFacturaCliente1(IClienteFacturaAccesRepo clienteFacturaAcces, IFacturaAccesRepo<Factura> facturaAccesRepo, SimpleInjector.Container container)
        {
            InitializeComponent();

            this.AllowAero = false;
            this.clienteFacturaAcces = clienteFacturaAcces;
            this.facturaAccesRepo = facturaAccesRepo;
            this.container = container;
        }

        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }

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
                loading.Dispose();
            }
        }

        private void Limpiar()
        {
            txtEstado.Clear();
            txtNumFactura.Clear();
            txtRutaFac.Clear();
            txtIdFac.Clear();

            btnInsertar.Visible = true;
            btnActualizar.Visible = false;
            gridFacturas.Columns[0].IsVisible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;
            webBrowser1.Visible = false;
            radSpreadsheet1.Visible = false;

            RutaOrigen = "";
            RutaDestino = "";

            dateFactura.Value = DateTime.Today;
        }


        private async Task Listar()
        {
            try
            {
                List<ClienteFacturas> clientesFacturas = await clienteFacturaAcces.Listar(ClienteId);

                gridFacturas.DataSource = clientesFacturas.Select(x => new
                {
                    x.ClienteId,
                    x.FacturaId,
                    x.Factura.NumeroFactura,
                    FechaEmision = x.Factura.FechaEmision.ToString("d"),
                    x.Factura.Estado,
                    x.Factura.ArchivoFactura
                });
                lblTotal.Text = "Total registros: " + gridFacturas.RowCount.ToString();
                lblNomClientne.Text = "Facturas pertenecientes a: " + NombreCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void EstilosGirdView()
        {
            gridFacturas.AllowCellContextMenu = false;
            gridFacturas.EnableFiltering = false;
            gridFacturas.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            if (gridFacturas.ColumnCount > 3)
            {
                gridFacturas.Columns[0].Width = 100;
                gridFacturas.Columns[0].AllowFiltering = false;

                gridFacturas.Columns[1].Width = 150;
                gridFacturas.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;

                gridFacturas.Columns[2].Width = 150;
                gridFacturas.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;


                gridFacturas.Columns[3].IsVisible = false;
                gridFacturas.Columns[4].IsVisible = false;

                gridFacturas.Columns[5].Width = 250;
                gridFacturas.Columns[5].HeaderText = "Número de Factura";
                gridFacturas.Columns[5].ReadOnly = true;
                gridFacturas.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;

                gridFacturas.Columns[6].Width = 250;
                gridFacturas.Columns[6].HeaderText = "Fecha de Emisión";
                gridFacturas.Columns[6].ReadOnly = true;
                gridFacturas.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;

                gridFacturas.Columns[7].Width = 250;
                gridFacturas.Columns[7].HeaderText = "Estado";
                gridFacturas.Columns[7].ReadOnly = true;
                gridFacturas.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

                gridFacturas.Columns[8].IsVisible = false;
            }

            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private Factura ObtenerDatosFacturas()
        {
            Factura factura = container.GetInstance<Factura>();

            factura.ArchivoFactura = txtRutaFac.Text.Trim();
            factura.Estado = txtEstado.Text.Trim();
            factura.NumeroFactura = txtNumFactura.Text.Trim();
            factura.FechaEmision = dateFactura.Value;

            return factura;
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
                foreach (Control control in radPanel1.Controls)
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


        private async void FrmFacturaCliente1_Load(object sender, EventArgs e)
        {
            #region LayoutControlConfigurations    

            radLayoutControl1.AllowCustomize = false;

            #endregion

            radValidationProvider1.ValidationMode = ValidationMode.Programmatically;

            Limpiar();

            ShowLoading();
            await Listar();
            HideLoanding();

            EstilosGirdView();
        }

        private void gridFacturas_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            var filePath = Path.Combine(Directorio, gridFacturas.CurrentRow.Cells[8].Value?.ToString());
            try
            {
                if (e.ColumnIndex == 1)
                {
                    if (Path.GetExtension(filePath) == ".xml")
                    {
                        Process.Start("IExplore.exe", filePath);
                    }
                    else
                    {
                        Process.Start(filePath);
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    if (Path.GetExtension(filePath) == ".xml")
                    {
                        saveFileDialog1.FileName = Path.GetFileName(filePath);

                        saveFileDialog1.Filter = "Archivos Xml (*.xml)|*.xml";

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(saveFileDialog1.FileName))
                            {
                                MessageBox.Show("Ya existe un archivo con el mismo nombre en la ruta que desea guardar. Porfavor ingrese un nombre diferente");
                                return;
                            }
                            else
                            {
                                File.Copy(filePath, saveFileDialog1.FileName);

                                MensajeOk("Factura Guardada Correctamente");
                            }
                        }
                    }
                    else if (Path.GetExtension(filePath) == ".xlsx")
                    {
                        saveFileDialog1.FileName = Path.GetFileName(filePath);

                        saveFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx";

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(saveFileDialog1.FileName))
                            {
                                MessageBox.Show("Ya existe un archivo con el mismo nombre en la ruta que desea guardar. Porfavor ingrese un nombre diferente");
                                return;
                            }
                            else
                            {
                                File.Copy(filePath, saveFileDialog1.FileName);
                                MensajeOk("Factura Guardada Correctamente");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gridFacturas_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo is GridViewCommandColumn)
            {
                if (e.ColumnIndex == 1)
                {
                    // This is how we get the RadButtonElement instance from the cell
                    RadButtonElement button = (RadButtonElement)e.CellElement.Children[0];

                    button.ButtonFillElement.BackColor = Color.FromArgb(77, 224, 36);
                    button.ForeColor = Color.White;
                    button.CustomFontSize = 11;
                }
                if (e.ColumnIndex == 2)
                {
                    // This is how we get the RadButtonElement instance from the cell
                    RadButtonElement button = (RadButtonElement)e.CellElement.Children[0];

                    button.ButtonFillElement.BackColor = Color.FromArgb(16, 110, 224);
                    button.ForeColor = Color.White;
                    button.CustomFontSize = 11;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tabForm.SelectedTab = tabListado;
        }

        private void toggleFiltrar_ValueChanged(object sender, EventArgs e)
        {
            if (toggleFiltrar.Value == true)
            {
                gridFacturas.EnableFiltering = true;
            }
            else
            {
                gridFacturas.EnableFiltering = false;
            }
        }

        private void chkSeleccionar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkSeleccionar.Checked)
            {
                gridFacturas.Columns[0].IsVisible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                gridFacturas.Columns[0].IsVisible = false;
                btnEliminar.Visible = false;
            }
        }

        private void txtNumFactura_TextChanging(object sender, TextChangingEventArgs e)
        {
            e.Cancel = !IsNumber(e.NewValue);
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
                    if (File.Exists(Path.Combine(Directorio, txtRutaFac.Text)))
                    {
                        MessageBox.Show("Ya existe un archivo con el mismo nombre. Cargue una factura con nombre de archivo diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return;
                    }

                    string respuesta = await facturaAccesRepo.Insertar(ObtenerDatosFacturas());

                    if (respuesta.Equals("OK"))
                    {
                        RutaDestino = Directorio + txtRutaFac.Text;
                        //El metodo Copy me permite copiar un file desde una ruta de origen a otro file nuevo en un ruta de destino
                        File.Copy(RutaOrigen, RutaDestino);

                        Factura facInsertada = facturaAccesRepo.ObtenerIdUltimaFactura();

                        string respuesta2 = await clienteFacturaAcces.Insertar(new ClienteFacturas() { ClienteId = ClienteId, FacturaId = facInsertada.FacturaId });

                        if (respuesta.Equals("OK"))
                        {
                            MensajeOk("Se insertó de forma correcta el registro");
                            Limpiar();
                            await Listar();
                        }
                        else
                        {
                            MensajeError(respuesta2);
                        }
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarFac_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";

                openFileDialog1.Filter = "Archivos Excel o Xml (*.xlsx, *.xls, *.xml)|*.xlsx;*.xls;*.xml";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog1.FileName) == ".xlsx" || Path.GetExtension(openFileDialog1.FileName) == ".xls")
                    {

                        radSpreadsheet1.Visible = true;
                        webBrowser1.Visible = false;

                        var formatProvider = new XlsxFormatProvider();

                        using (FileStream input = new FileStream(openFileDialog1.FileName, FileMode.Open))
                        {
                            radSpreadsheet1.Workbook = formatProvider.Import(input);
                        }

                        txtRutaFac.Text = Path.GetFileName(openFileDialog1.FileName);

                        this.RutaOrigen = openFileDialog1.FileName;
                    }
                    else if (Path.GetExtension(openFileDialog1.FileName) == ".xml")
                    {
                        radSpreadsheet1.Visible = false;
                        webBrowser1.Visible = true;

                        webBrowser1.Navigate(openFileDialog1.FileName);

                        txtRutaFac.Text = Path.GetFileName(openFileDialog1.FileName);

                        this.RutaOrigen = openFileDialog1.FileName;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void gridFacturas_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;

                txtIdFac.Text = gridFacturas.CurrentRow.Cells["FacturaId"].Value?.ToString();
                txtEstado.Text = gridFacturas.CurrentRow.Cells["Estado"].Value?.ToString();
                txtNumFactura.Text = gridFacturas.CurrentRow.Cells["NumeroFactura"].Value?.ToString();
                numFacAnt = gridFacturas.CurrentRow.Cells["NumeroFactura"].Value?.ToString();
                dateFactura.Value = Convert.ToDateTime(gridFacturas.CurrentRow.Cells["FechaEmision"].Value?.ToString());
                txtRutaFac.Text = gridFacturas.CurrentRow.Cells["ArchivoFactura"].Value?.ToString();
                rutaFacAnt = gridFacturas.CurrentRow.Cells["ArchivoFactura"].Value?.ToString();

                var rutaFile = Path.Combine(Directorio, txtRutaFac.Text);

                if (Path.GetExtension(rutaFile) == ".xml")
                {
                    radSpreadsheet1.Visible = false;
                    webBrowser1.Visible = true;

                    webBrowser1.Navigate(rutaFile);
                }
                else if (Path.GetExtension(rutaFile) == ".xlsx")
                {
                    radSpreadsheet1.Visible = true;
                    webBrowser1.Visible = false;

                    var formatProvider = new XlsxFormatProvider();

                    using (FileStream input = new FileStream(rutaFile, FileMode.Open))
                    {
                        radSpreadsheet1.Workbook = formatProvider.Import(input);
                    }
                }

                tabForm.SelectedTab = tabManteniminento;

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
                var validaciones = ValidarCampos();

                if (validaciones.Contains(false))
                {
                    return;
                }
                else
                {
                    var filePath = Path.Combine(Directorio, txtRutaFac.Text);

                    if (File.Exists(filePath) && RutaOrigen != "" && rutaFacAnt != txtRutaFac.Text)
                    {
                        MessageBox.Show("Ya existe un archivo con el mismo nombre. Cargue una factura con nombre de archivo diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return;
                    }

                    var factura = ObtenerDatosFacturas();

                    factura.FacturaId = Convert.ToInt32(txtIdFac.Text);

                    string respuesta = await facturaAccesRepo.Actualizar(factura, numFacAnt);

                    if (respuesta.Equals("OK"))
                    {
                        RutaDestino = Directorio + txtRutaFac.Text;
                        //El metodo Copy me permite copiar un file desde una ruta de origen a otro file nuevo en un ruta de destino
                        if (txtRutaFac.Text != rutaFacAnt)
                        {
                            File.Delete(Path.Combine(Directorio, rutaFacAnt));
                            File.Copy(RutaOrigen, RutaDestino);
                        }

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
                    int facturaId;
                    string respuesta;

                    foreach (var fila in gridFacturas.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            facturaId = Convert.ToInt32(fila.Cells[4].Value);

                            respuesta = await facturaAccesRepo.Eliminar(facturaId);

                            if (respuesta.Equals("OK"))
                            {
                                File.Delete(Path.Combine(Directorio, fila.Cells[8].Value?.ToString()));

                                MensajeOk("Se elimió la factura con número: " + fila.Cells[5].Value?.ToString());
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

    }
}
