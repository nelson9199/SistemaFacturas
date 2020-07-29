namespace Sistema.Presentacion
{
    partial class FrmConvertidorXmlAExcel
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
            this.txtFilePath = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilePath.Location = new System.Drawing.Point(196, 95);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            // 
            // 
            // 
            this.txtFilePath.RootElement.StretchVertically = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilePath.Size = new System.Drawing.Size(508, 53);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(196, 179);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(198, 45);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Cargar Archivo Xml";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton2.Location = new System.Drawing.Point(507, 179);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(197, 45);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Exportar a Excel";
            this.radButton2.ThemeName = "Material";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // FrmConvertidorXmlAExcel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 357);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtFilePath);
            this.Name = "FrmConvertidorXmlAExcel";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Convertidor Xml a Excel";
            this.ThemeName = "Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConvertidorXmlAExcel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtFilePath;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}
