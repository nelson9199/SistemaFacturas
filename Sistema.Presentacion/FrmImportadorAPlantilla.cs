using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Sistema.Presentacion
{
    public partial class FrmImportadorAPlantilla : Telerik.WinControls.UI.RadForm
    {
        private string xmlFile;
        private string excelFile;

        public FrmImportadorAPlantilla()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KillBackgroudProcess(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                if (string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    process.Kill();
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                KillBackgroudProcess("excel");

                openFileDialog1.FileName = "";

                openFileDialog1.Filter = "Archivos xml (*.xml)|*.xml";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xmlFile = openFileDialog1.FileName;

                    txtXml.Text = Path.GetFileName(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            if (txtXml.Text == "" || txtPlantilla.Text == "")
            {
                MensajeError("Debe seleccionar el Archivo Xml y la plantilla Excel ATS antes de hacer la importacion");
                return;
            }
            else
            {
                try
                {
                    KillBackgroudProcess("excel");

                    Microsoft.Office.Interop.Excel.Application xApp = new Microsoft.Office.Interop.Excel.Application();
                    Workbook excelWorkBook = xApp.Workbooks.Open(excelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    var ds = new DataSet();
                    ds.ReadXmlSchema(xmlFile);

                    XmlDocument xmlDoc = new XmlDocument();

                    xmlDoc.Load(xmlFile);

                    string rootName = xmlDoc.FirstChild.NextSibling.Name;

                    XmlMap xmlMap1 = excelWorkBook.XmlMaps.Add(ds.GetXmlSchema(), rootName);

                    var importResult = excelWorkBook.XmlImport(xmlFile, out xmlMap1, true, Type.Missing);

                    if (importResult == XlXmlImportResult.xlXmlImportValidationFailed)
                    {
                        MensajeOk("Importacion Exsitosa. Cierre esta ventana una vez haya terminado las importaciones");
                    }
                    else
                    {
                        MensajeError("No se pudo realizar la exportacion");

                        excelWorkBook.Close();
                        xApp.Workbooks.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                KillBackgroudProcess("excel");

                openFileDialog2.FileName = "";

                openFileDialog2.Filter = "Archivos Excel(*.xls, *.xlsx)|*.xls;*.xlsx";

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    excelFile = openFileDialog2.FileName;

                    txtPlantilla.Text = Path.GetFileName(openFileDialog2.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConvertidorAExcel_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                KillBackgroudProcess("excel");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
