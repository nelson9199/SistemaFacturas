namespace Sistema.Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.menuItemAccesos = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuItemHerramienta = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuItemSalir = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
            this.cBClientes = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.menuItemCliente = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.menuItemDb = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer2 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.stLabelStatus = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemAccesos
            // 
            this.menuItemAccesos.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5});
            this.menuItemAccesos.Name = "menuItemAccesos";
            this.menuItemAccesos.Text = "Accesos";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Image = global::Sistema.Presentacion.Properties.Resources.group_key;
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Roles";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Image = global::Sistema.Presentacion.Properties.Resources.group_add;
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Usuarios";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // menuItemHerramienta
            // 
            this.menuItemHerramienta.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem8,
            this.radMenuItem9});
            this.menuItemHerramienta.Name = "menuItemHerramienta";
            this.menuItemHerramienta.Text = "Herramientas";
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Image = global::Sistema.Presentacion.Properties.Resources.import_icon;
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Importar Xml a plantilla ATS Excel";
            this.radMenuItem8.Click += new System.EventHandler(this.radMenuItem8_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Image = global::Sistema.Presentacion.Properties.Resources.table_import_icon;
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Importar Xml a nuevo Excel";
            this.radMenuItem9.Click += new System.EventHandler(this.radMenuItem9_Click);
            // 
            // menuItemSalir
            // 
            this.menuItemSalir.Name = "menuItemSalir";
            this.menuItemSalir.Text = "Salir";
            this.menuItemSalir.Click += new System.EventHandler(this.menuItemSalir_Click);
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 37);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(1263, 48);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.ThemeName = "Material";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "Barra de Herramientas";
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton3,
            this.commandBarButton4,
            this.cBClientes});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.DisplayName = "Botón Importador Xml a plantilla ATS";
            this.commandBarButton3.Image = global::Sistema.Presentacion.Properties.Resources.import_icon;
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "Botón Importado Xml a plantilla ATS";
            this.commandBarButton3.ToolTipText = "Importar Xml a plantilla ATS Excel";
            this.commandBarButton3.Click += new System.EventHandler(this.commandBarButton3_Click);
            // 
            // commandBarButton4
            // 
            this.commandBarButton4.DisplayName = "Botón convertidor  Xml a Excel";
            this.commandBarButton4.Image = global::Sistema.Presentacion.Properties.Resources.table_import_icon;
            this.commandBarButton4.Name = "commandBarButton4";
            this.commandBarButton4.Text = "Botón convertidor  Xml a Excel";
            this.commandBarButton4.ToolTipText = "Importar Xml a nuevo Excel";
            this.commandBarButton4.Click += new System.EventHandler(this.commandBarButton4_Click);
            // 
            // cBClientes
            // 
            this.cBClientes.DisplayName = "Boton Clientes";
            this.cBClientes.Image = global::Sistema.Presentacion.Properties.Resources.cliente_m;
            this.cBClientes.Name = "cBClientes";
            this.cBClientes.Text = "Botón Clientes";
            this.cBClientes.ToolTipText = "Clientes";
            this.cBClientes.Click += new System.EventHandler(this.cBClientes_Click);
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarButton2});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.Image = global::Sistema.Presentacion.Properties.Resources.cliente_m;
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "";
            this.commandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.UseCompatibleTextRendering = false;
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton2";
            this.commandBarButton2.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton2.Image")));
            this.commandBarButton2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "commandBarButton2";
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.UseCompatibleTextRendering = false;
            // 
            // menuItemCliente
            // 
            this.menuItemCliente.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.menuItemCliente.Name = "menuItemCliente";
            this.menuItemCliente.Text = "Clientes";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Sistema.Presentacion.Properties.Resources.cliente_m;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Clientes";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuItemCliente,
            this.menuItemAccesos,
            this.menuItemHerramienta,
            this.menuItemDb,
            this.menuItemSalir});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1263, 37);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.ThemeName = "Material";
            // 
            // menuItemDb
            // 
            this.menuItemDb.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3});
            this.menuItemDb.Name = "menuItemDb";
            this.menuItemDb.Text = "Base de datos";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Image = global::Sistema.Presentacion.Properties.Resources.database_save;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Generar copia de seguridad";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radDock1
            // 
            this.radDock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.radDock1.Controls.Add(this.documentContainer2);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 85);
            this.radDock1.MainDocumentContainer = this.documentContainer2;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radDock1.RootElement.BorderHighlightColor = System.Drawing.Color.White;
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(1263, 540);
            this.radDock1.SplitterWidth = 8;
            this.radDock1.TabIndex = 5;
            this.radDock1.TabStop = false;
            this.radDock1.ThemeName = "Material";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDock1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDock1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDock1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDock1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDock1.GetChildAt(0).GetChildAt(1))).BottomShadowColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.Docking.AutoHideTabStripElement)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            ((Telerik.WinControls.UI.Docking.AutoHideTabStripElement)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            ((Telerik.WinControls.UI.Docking.AutoHideTabStripElement)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radDock1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            // 
            // documentContainer2
            // 
            this.documentContainer2.Name = "documentContainer2";
            // 
            // 
            // 
            this.documentContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer2.SplitterWidth = 8;
            this.documentContainer2.ThemeName = "Material";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.stLabelStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 600);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1263, 25);
            this.radStatusStrip1.TabIndex = 6;
            this.radStatusStrip1.ThemeName = "Material";
            // 
            // stLabelStatus
            // 
            this.stLabelStatus.Name = "stLabelStatus";
            this.radStatusStrip1.SetSpring(this.stLabelStatus, false);
            this.stLabelStatus.Text = "Desarrollado por X-Development";
            this.stLabelStatus.TextWrap = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1263, 625);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Escritorio";
            this.ThemeName = "Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadMenuItem menuItemAccesos;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem menuItemHerramienta;
        private Telerik.WinControls.UI.RadMenuItem menuItemSalir;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadMenuItem menuItemCliente;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
        private Telerik.WinControls.UI.CommandBarButton cBClientes;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement stLabelStatus;
        private Telerik.WinControls.UI.RadMenuItem menuItemDb;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
    }
}
