namespace Sistema.Presentacion
{
    partial class FrmRol
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radLayoutControl1 = new Telerik.WinControls.UI.RadLayoutControl();
            this.gridRoles = new Telerik.WinControls.UI.RadGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.layoutControlItem1 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.layoutControlItem2 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlLabelItem3 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.radLayoutControl1)).BeginInit();
            this.radLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLayoutControl1
            // 
            this.radLayoutControl1.Controls.Add(this.gridRoles);
            this.radLayoutControl1.Controls.Add(this.lblTotal);
            this.radLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLayoutControl1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.layoutControlItem1,
            this.layoutControlLabelItem2,
            this.layoutControlItem2,
            this.layoutControlLabelItem3});
            this.radLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.radLayoutControl1.Name = "radLayoutControl1";
            this.radLayoutControl1.Size = new System.Drawing.Size(558, 364);
            this.radLayoutControl1.TabIndex = 0;
            this.radLayoutControl1.ThemeName = "Material";
            // 
            // gridRoles
            // 
            this.gridRoles.Location = new System.Drawing.Point(4, 4);
            // 
            // 
            // 
            this.gridRoles.MasterTemplate.AllowAddNewRow = false;
            this.gridRoles.MasterTemplate.AllowColumnReorder = false;
            this.gridRoles.MasterTemplate.AllowDeleteRow = false;
            this.gridRoles.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.gridRoles.MasterTemplate.EnableGrouping = false;
            this.gridRoles.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.Size = new System.Drawing.Size(550, 330);
            this.gridRoles.TabIndex = 4;
            this.gridRoles.ThemeName = "Material";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Registros:";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AssociatedControl = this.gridRoles;
            this.layoutControlItem1.Bounds = new System.Drawing.Rectangle(0, 0, 556, 336);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "";
            // 
            // layoutControlLabelItem2
            // 
            this.layoutControlLabelItem2.Bounds = new System.Drawing.Rectangle(183, 336, 373, 26);
            this.layoutControlLabelItem2.DrawText = false;
            this.layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AssociatedControl = this.lblTotal;
            this.layoutControlItem2.Bounds = new System.Drawing.Rectangle(46, 336, 137, 26);
            this.layoutControlItem2.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "layoutControlItem2";
            // 
            // layoutControlLabelItem3
            // 
            this.layoutControlLabelItem3.Bounds = new System.Drawing.Rectangle(0, 336, 46, 26);
            this.layoutControlLabelItem3.DrawText = false;
            this.layoutControlLabelItem3.Name = "layoutControlLabelItem3";
            // 
            // FrmRol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(558, 364);
            this.Controls.Add(this.radLayoutControl1);
            this.MaximizeBox = false;
            this.Name = "FrmRol";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLayoutControl1)).EndInit();
            this.radLayoutControl1.ResumeLayout(false);
            this.radLayoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadLayoutControl radLayoutControl1;
        private Telerik.WinControls.UI.RadGridView gridRoles;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
        private System.Windows.Forms.Label lblTotal;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem3;
    }
}
