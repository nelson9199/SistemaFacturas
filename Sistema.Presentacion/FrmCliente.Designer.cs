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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radLayoutControl1 = new Telerik.WinControls.UI.RadLayoutControl();
            this.gridClientes = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSeleccionar = new Telerik.WinControls.UI.RadCheckBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radToggleSwitch1 = new Telerik.WinControls.UI.RadToggleSwitch();
            this.layoutControlItem1 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem1 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlItem2 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem3 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlLabelItem4 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlItem3 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem5 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlItem4 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlItem5 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlItem6 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem6 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlLabelItem7 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlLabelItem8 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlLabelItem10 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlItem7 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlItem8 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem9 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.radTabbedFormControlTab2 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            this.radTabbedFormControlTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLayoutControl1)).BeginInit();
            this.radLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleSwitch1)).BeginInit();
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
            this.radTabbedFormControl1.Size = new System.Drawing.Size(1227, 626);
            this.radTabbedFormControl1.TabHeight = 32;
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.TabSpacing = -1;
            this.radTabbedFormControl1.Text = "Clientes";
            this.radTabbedFormControl1.ThemeName = "Material";
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Controls.Add(this.radLayoutControl1);
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(1225, 588);
            this.radTabbedFormControlTab1.Text = "Listado";
            // 
            // radLayoutControl1
            // 
            this.radLayoutControl1.Controls.Add(this.gridClientes);
            this.radLayoutControl1.Controls.Add(this.label1);
            this.radLayoutControl1.Controls.Add(this.chkSeleccionar);
            this.radLayoutControl1.Controls.Add(this.radButton1);
            this.radLayoutControl1.Controls.Add(this.radButton2);
            this.radLayoutControl1.Controls.Add(this.radButton3);
            this.radLayoutControl1.Controls.Add(this.label2);
            this.radLayoutControl1.Controls.Add(this.radToggleSwitch1);
            this.radLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLayoutControl1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.layoutControlItem1,
            this.layoutControlLabelItem1,
            this.layoutControlLabelItem2,
            this.layoutControlItem2,
            this.layoutControlLabelItem3,
            this.layoutControlLabelItem4,
            this.layoutControlItem3,
            this.layoutControlLabelItem5,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlLabelItem6,
            this.layoutControlLabelItem7,
            this.layoutControlLabelItem8,
            this.layoutControlLabelItem10,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlLabelItem9});
            this.radLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.radLayoutControl1.Name = "radLayoutControl1";
            this.radLayoutControl1.Size = new System.Drawing.Size(1225, 588);
            this.radLayoutControl1.TabIndex = 0;
            // 
            // gridClientes
            // 
            this.gridClientes.Location = new System.Drawing.Point(3, 29);
            // 
            // 
            // 
            this.gridClientes.MasterTemplate.AllowAddNewRow = false;
            this.gridClientes.MasterTemplate.AllowColumnReorder = false;
            gridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            gridViewCheckBoxColumn1.Name = "seleccionar";
            this.gridClientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1});
            this.gridClientes.MasterTemplate.EnablePaging = true;
            this.gridClientes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(1202, 461);
            this.gridClientes.TabIndex = 3;
            this.gridClientes.ThemeName = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Registros:";
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.Location = new System.Drawing.Point(270, 522);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(101, 19);
            this.chkSeleccionar.TabIndex = 5;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(418, 522);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(127, 20);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Eliminar";
            this.radButton1.ThemeName = "Material";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(614, 522);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(136, 20);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "Activar";
            this.radButton2.ThemeName = "Material";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(812, 522);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(141, 20);
            this.radButton3.TabIndex = 8;
            this.radButton3.Text = "Desactivar";
            this.radButton3.ThemeName = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtrar";
            // 
            // radToggleSwitch1
            // 
            this.radToggleSwitch1.Location = new System.Drawing.Point(95, 3);
            this.radToggleSwitch1.Name = "radToggleSwitch1";
            this.radToggleSwitch1.Size = new System.Drawing.Size(40, 20);
            this.radToggleSwitch1.TabIndex = 10;
            this.radToggleSwitch1.ThemeName = "Material";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AssociatedControl = this.gridClientes;
            this.layoutControlItem1.Bounds = new System.Drawing.Rectangle(0, 26, 1208, 467);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "";
            // 
            // layoutControlLabelItem1
            // 
            this.layoutControlLabelItem1.Bounds = new System.Drawing.Rectangle(138, 0, 1070, 26);
            this.layoutControlLabelItem1.DrawText = false;
            this.layoutControlLabelItem1.Name = "layoutControlLabelItem1";
            // 
            // layoutControlLabelItem2
            // 
            this.layoutControlLabelItem2.Bounds = new System.Drawing.Rectangle(956, 519, 252, 26);
            this.layoutControlLabelItem2.DrawText = false;
            this.layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AssociatedControl = this.label1;
            this.layoutControlItem2.Bounds = new System.Drawing.Rectangle(46, 519, 175, 26);
            this.layoutControlItem2.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "layoutControlItem2";
            // 
            // layoutControlLabelItem3
            // 
            this.layoutControlLabelItem3.Bounds = new System.Drawing.Rectangle(0, 519, 46, 26);
            this.layoutControlLabelItem3.DrawText = false;
            this.layoutControlLabelItem3.Name = "layoutControlLabelItem3";
            // 
            // layoutControlLabelItem4
            // 
            this.layoutControlLabelItem4.Bounds = new System.Drawing.Rectangle(221, 519, 46, 26);
            this.layoutControlLabelItem4.DrawText = false;
            this.layoutControlLabelItem4.Name = "layoutControlLabelItem4";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AssociatedControl = this.chkSeleccionar;
            this.layoutControlItem3.Bounds = new System.Drawing.Rectangle(267, 519, 102, 26);
            this.layoutControlItem3.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "layoutControlItem3";
            // 
            // layoutControlLabelItem5
            // 
            this.layoutControlLabelItem5.Bounds = new System.Drawing.Rectangle(369, 519, 46, 26);
            this.layoutControlLabelItem5.DrawText = false;
            this.layoutControlLabelItem5.Name = "layoutControlLabelItem5";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AssociatedControl = this.radButton1;
            this.layoutControlItem4.Bounds = new System.Drawing.Rectangle(415, 519, 133, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "layoutControlItem4";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AssociatedControl = this.radButton2;
            this.layoutControlItem5.Bounds = new System.Drawing.Rectangle(611, 519, 142, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "layoutControlItem5";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AssociatedControl = this.radButton3;
            this.layoutControlItem6.Bounds = new System.Drawing.Rectangle(809, 519, 147, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "layoutControlItem6";
            // 
            // layoutControlLabelItem6
            // 
            this.layoutControlLabelItem6.Bounds = new System.Drawing.Rectangle(548, 519, 63, 26);
            this.layoutControlLabelItem6.DrawText = false;
            this.layoutControlLabelItem6.Name = "layoutControlLabelItem6";
            // 
            // layoutControlLabelItem7
            // 
            this.layoutControlLabelItem7.Bounds = new System.Drawing.Rectangle(753, 519, 56, 26);
            this.layoutControlLabelItem7.DrawText = false;
            this.layoutControlLabelItem7.Name = "layoutControlLabelItem7";
            // 
            // layoutControlLabelItem8
            // 
            this.layoutControlLabelItem8.Bounds = new System.Drawing.Rectangle(0, 493, 1208, 26);
            this.layoutControlLabelItem8.DrawText = false;
            this.layoutControlLabelItem8.Name = "layoutControlLabelItem8";
            // 
            // layoutControlLabelItem10
            // 
            this.layoutControlLabelItem10.Bounds = new System.Drawing.Rectangle(0, 0, 46, 26);
            this.layoutControlLabelItem10.DrawText = false;
            this.layoutControlLabelItem10.Name = "layoutControlLabelItem10";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AssociatedControl = this.label2;
            this.layoutControlItem7.Bounds = new System.Drawing.Rectangle(46, 0, 46, 26);
            this.layoutControlItem7.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "layoutControlItem7";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AssociatedControl = this.radToggleSwitch1;
            this.layoutControlItem8.Bounds = new System.Drawing.Rectangle(92, 0, 46, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Text = "layoutControlItem8";
            // 
            // layoutControlLabelItem9
            // 
            this.layoutControlLabelItem9.Bounds = new System.Drawing.Rectangle(0, 545, 1208, 26);
            this.layoutControlLabelItem9.DrawText = false;
            this.layoutControlLabelItem9.Name = "layoutControlLabelItem9";
            // 
            // radTabbedFormControlTab2
            // 
            this.radTabbedFormControlTab2.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2";
            this.radTabbedFormControlTab2.Size = new System.Drawing.Size(1225, 588);
            this.radTabbedFormControlTab2.Text = "Mantenimiento";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 626);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "FrmCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Clientes";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            this.radTabbedFormControlTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLayoutControl1)).EndInit();
            this.radLayoutControl1.ResumeLayout(false);
            this.radLayoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab2;
        private Telerik.WinControls.UI.RadLayoutControl radLayoutControl1;
        private Telerik.WinControls.UI.RadGridView gridClientes;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadCheckBox chkSeleccionar;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadToggleSwitch radToggleSwitch1;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem3;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem4;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem3;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem5;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem5;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem6;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem6;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem7;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem8;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem10;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem7;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem8;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem9;
    }
}
