using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmConvertidorXmlAExcel : Telerik.WinControls.UI.RadForm
    {
        public FrmConvertidorXmlAExcel()
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

                radTextBox1.Text = file;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "")
            {
                MensajeError("Debe cargar un archivo Xml para poder exportar a Excel");
                return;
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application xApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkBook = xApp.Workbooks.OpenXML(radTextBox1.Text, Type.Missing, XlXmlLoadOption.xlXmlLoadImportToList);
            }
        }

        private void FrmConvertidorXmlAExcel_FormClosed(object sender, FormClosedEventArgs e)
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
