using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace Sistema.Presentacion
{
    public partial class FrmImportadorAPlantilla : Telerik.WinControls.UI.RadForm
    {
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos xml (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;

                txtFiles.Text = file;
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkBook = xApp.Workbooks.Open(radTextBox2.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                var ds = new DataSet();
                ds.ReadXmlSchema(txtFiles.Text);

                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load(txtFiles.Text);

                string rootName = xmlDoc.FirstChild.NextSibling.Name;

                XmlMap xmlMap1 = excelWorkBook.XmlMaps.Add(ds.GetXmlSchema(), rootName);

                var importResult = excelWorkBook.XmlImport(txtFiles.Text, out xmlMap1, true, Type.Missing);

                if (importResult == XlXmlImportResult.xlXmlImportValidationFailed)
                {
                    MensajeOk("Importacion Exsitosa");
                }
                else
                {
                    MensajeError("No se pudo realizar la exportacion");

                    excelWorkBook.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Archivos Excel(*.xls, *.xlsx)|*.xls;*.xlsx";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog2.FileName;

                radTextBox2.Text = file;

            }
        }

        private void txtFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConvertidorAExcel_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("excel"))
            {
                if (string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    process.Kill();
                }
            }
        }
    }
}
