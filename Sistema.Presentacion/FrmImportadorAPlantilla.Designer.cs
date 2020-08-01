namespace Sistema.Presentacion
{
    partial class FrmImportadorAPlantilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.object_e5730347_91d5_49e9_bf4c_6ba8e4c41197 = new Telerik.WinControls.RootRadElement();
            this.layoutControlItem4 = new Telerik.WinControls.UI.LayoutControlItem();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.txtPlantilla = new Telerik.WinControls.UI.RadTextBox();
            this.txtXml = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // object_e5730347_91d5_49e9_bf4c_6ba8e4c41197
            // 
            this.object_e5730347_91d5_49e9_bf4c_6ba8e4c41197.Name = "object_e5730347_91d5_49e9_bf4c_6ba8e4c41197";
            this.object_e5730347_91d5_49e9_bf4c_6ba8e4c41197.StretchHorizontally = true;
            this.object_e5730347_91d5_49e9_bf4c_6ba8e4c41197.StretchVertically = true;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AssociatedControl = null;
            this.layoutControlItem4.Bounds = new System.Drawing.Rectangle(583, 161, 209, 26);
            this.layoutControlItem4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.layoutControlItem4.UseCompatibleTextRendering = false;
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(134, 159);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(212, 42);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Cargar Archivo Xml";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton2.Location = new System.Drawing.Point(638, 159);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(252, 42);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "Cargar Plantilla ATS Excel";
            this.radButton2.ThemeName = "Material";
            this.radButton2.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton3
            // 
            this.radButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton3.Location = new System.Drawing.Point(384, 207);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(217, 42);
            this.radButton3.TabIndex = 0;
            this.radButton3.Text = "Realizar Exportacion";
            this.radButton3.ThemeName = "Material";
            this.radButton3.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // txtPlantilla
            // 
            this.txtPlantilla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlantilla.Location = new System.Drawing.Point(519, 93);
            this.txtPlantilla.Name = "txtPlantilla";
            this.txtPlantilla.ReadOnly = true;
            this.txtPlantilla.Size = new System.Drawing.Size(446, 36);
            this.txtPlantilla.TabIndex = 1;
            this.txtPlantilla.ThemeName = "Material";
            // 
            // txtXml
            // 
            this.txtXml.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtXml.Location = new System.Drawing.Point(27, 93);
            this.txtXml.Name = "txtXml";
            this.txtXml.ReadOnly = true;
            this.txtXml.Size = new System.Drawing.Size(452, 36);
            this.txtXml.TabIndex = 1;
            this.txtXml.ThemeName = "Material";
            // 
            // FrmImportadorAPlantilla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 310);
            this.Controls.Add(this.txtXml);
            this.Controls.Add(this.txtPlantilla);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton1);
            this.Name = "FrmImportadorAPlantilla";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Importar xml a plantilla ATS";
            this.ThemeName = "Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConvertidorAExcel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.RootRadElement object_e5730347_91d5_49e9_bf4c_6ba8e4c41197;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadTextBox txtPlantilla;
        private Telerik.WinControls.UI.RadTextBox txtXml;
    }
}
