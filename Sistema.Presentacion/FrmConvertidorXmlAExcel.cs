using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmConvertidorXmlAExcel : Telerik.WinControls.UI.RadForm
    {
        private List<string> rutas = new List<string>();

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
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivos xml (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = "";

                foreach (var item in openFileDialog1.FileNames)
                {
                    rutas.Add(item);

                    txtFilePath.Text += Path.GetFileName(item) + ",  ";
                }
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "")
            {
                MensajeError("Debe cargar un archivo Xml para poder exportar a Excel");
                return;
            }
            else
            {
                foreach (var item in rutas)
                {
                    Microsoft.Office.Interop.Excel.Application xApp = new Microsoft.Office.Interop.Excel.Application();
                    Workbook excelWorkBook = xApp.Workbooks.OpenXML(item, Type.Missing, XlXmlLoadOption.xlXmlLoadImportToList);
                }

                rutas.Clear();
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
