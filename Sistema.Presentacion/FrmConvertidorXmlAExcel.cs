﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmConvertidorXmlAExcel : Telerik.WinControls.UI.RadForm
    {
        private List<string> rutas = new List<string>();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern System.IntPtr FindWindow(string lpClassName, string lpWindowName);

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
            try
            {
                KillBackgroudProcess("excel");

                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Archivos xml (*.xml)|*.xml";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutas.Clear();

                    txtFilePath.Text = "";

                    foreach (var item in openFileDialog1.FileNames)
                    {
                        rutas.Add(item);

                        txtFilePath.Text += Path.GetFileName(item) + ",  ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
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
                        xApp.Visible = true;
                        xApp.WindowState = XlWindowState.xlMaximized;
                        string caption = xApp.Caption;
                        IntPtr handler = FindWindow(null, caption);
                        SetForegroundWindow(handler);

                        Workbook excelWorkBook = xApp.Workbooks.OpenXML(item, Type.Missing, XlXmlLoadOption.xlXmlLoadImportToList);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmConvertidorXmlAExcel_FormClosed(object sender, FormClosedEventArgs e)
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
