namespace Sistema.Presentacion
{
    partial class FrmUsuario
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
            this.tabForm = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.tabListado = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.tabMantenimiento = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            ((System.ComponentModel.ISupportInitialize)(this.tabForm)).BeginInit();
            this.tabForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.CaptionHeight = 36;
            this.tabForm.Controls.Add(this.tabListado);
            this.tabForm.Controls.Add(this.tabMantenimiento);
            this.tabForm.ItemDragMode = Telerik.WinControls.UI.TabItemDragMode.None;
            this.tabForm.Location = new System.Drawing.Point(0, 0);
            this.tabForm.MaximizeButton = false;
            this.tabForm.MinimizeButton = false;
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedTab = this.tabListado;
            this.tabForm.ShowNewTabButton = false;
            this.tabForm.ShowTabCloseButton = false;
            this.tabForm.Size = new System.Drawing.Size(1128, 591);
            this.tabForm.TabHeight = 32;
            this.tabForm.TabIndex = 0;
            this.tabForm.TabSpacing = -1;
            this.tabForm.Text = "Usuarios";
            this.tabForm.ThemeName = "Material";
            // 
            // tabListado
            // 
            this.tabListado.Location = new System.Drawing.Point(1, 37);
            this.tabListado.Name = "tabListado";
            this.tabListado.Size = new System.Drawing.Size(1126, 553);
            this.tabListado.Text = "Listado";
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Location = new System.Drawing.Point(1, 37);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Size = new System.Drawing.Size(1138, 561);
            this.tabMantenimiento.Text = "Mantenimiento";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 591);
            this.Controls.Add(this.tabForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Usuarios";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.tabForm)).EndInit();
            this.tabForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl tabForm;
        private Telerik.WinControls.UI.RadTabbedFormControlTab tabListado;
        private Telerik.WinControls.UI.RadTabbedFormControlTab tabMantenimiento;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}
