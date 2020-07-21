namespace Sistema.Presentacion
{
    partial class FrmCliente
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
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTabbedFormControlTab2 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.CaptionHeight = 36;
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab2);
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.MaximizeButton = false;
            this.radTabbedFormControl1.MinimizeButton = false;
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.ShowNewTabButton = false;
            this.radTabbedFormControl1.ShowTabCloseButton = false;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(1230, 626);
            this.radTabbedFormControl1.TabHeight = 32;
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.TabSpacing = -1;
            this.radTabbedFormControl1.Text = "Clientes";
            this.radTabbedFormControl1.ThemeName = "Material";
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(1228, 588);
            this.radTabbedFormControlTab1.Text = "Listado";
            this.radTabbedFormControlTab1.Paint += new System.Windows.Forms.PaintEventHandler(this.radTabbedFormControlTab1_Paint);
            // 
            // radTabbedFormControlTab2
            // 
            this.radTabbedFormControlTab2.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2";
            this.radTabbedFormControlTab2.Size = new System.Drawing.Size(1228, 588);
            this.radTabbedFormControlTab2.Text = "Mantenimiento";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 626);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "FrmCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Clientes";
            this.ThemeName = "Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab2;
    }
}
