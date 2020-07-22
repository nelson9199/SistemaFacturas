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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton5 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radWaitingBar3 = new Telerik.WinControls.UI.RadWaitingBar();
            this.segmentedRingWaitingBarIndicatorElement3 = new Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.segmentedRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement();
            this.radWaitingBar2 = new Telerik.WinControls.UI.RadWaitingBar();
            this.segmentedRingWaitingBarIndicatorElement2 = new Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.radMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Accesos";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Image = global::Sistema.Presentacion.Properties.Resources.group_key;
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Roles";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Image = global::Sistema.Presentacion.Properties.Resources.group_add;
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Usuarios";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem8,
            this.radMenuItem9});
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Herramientas";
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
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Salir";
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
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton3,
            this.commandBarButton4,
            this.commandBarButton5});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.DisplayName = "commandBarButton3";
            this.commandBarButton3.Image = global::Sistema.Presentacion.Properties.Resources.import_icon;
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "commandBarButton3";
            // 
            // commandBarButton4
            // 
            this.commandBarButton4.DisplayName = "commandBarButton4";
            this.commandBarButton4.Image = global::Sistema.Presentacion.Properties.Resources.table_import_icon;
            this.commandBarButton4.Name = "commandBarButton4";
            this.commandBarButton4.Text = "commandBarButton4";
            // 
            // commandBarButton5
            // 
            this.commandBarButton5.DisplayName = "commandBarButton5";
            this.commandBarButton5.Image = global::Sistema.Presentacion.Properties.Resources.cliente_m;
            this.commandBarButton5.Name = "commandBarButton5";
            this.commandBarButton5.Text = "commandBarButton5";
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
            this.commandBarButton2.Image = global::Sistema.Presentacion.Properties.Resources.Banned_User;
            this.commandBarButton2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "commandBarButton2";
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.UseCompatibleTextRendering = false;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Clientes";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Sistema.Presentacion.Properties.Resources.cliente_m;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Clientes";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radDock1
            // 
            this.radDock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 85);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radDock1.RootElement.BorderHighlightColor = System.Drawing.Color.White;
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(1263, 540);
            this.radDock1.SplitterWidth = 8;
            this.radDock1.TabIndex = 3;
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
            // documentContainer1
            // 
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SplitterWidth = 8;
            this.documentContainer1.ThemeName = "Material";
            // 
            // radMenu1
            // 
            this.radMenu1.Controls.Add(this.radWaitingBar3);
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem3,
            this.radMenuItem6,
            this.radMenuItem7});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1263, 37);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.ThemeName = "Material";
            // 
            // radWaitingBar3
            // 
            this.radWaitingBar3.Location = new System.Drawing.Point(683, 26);
            this.radWaitingBar3.Name = "radWaitingBar3";
            this.radWaitingBar3.Size = new System.Drawing.Size(88, 88);
            this.radWaitingBar3.TabIndex = 5;
            this.radWaitingBar3.Text = "radWaitingBar3";
            this.radWaitingBar3.WaitingIndicators.Add(this.segmentedRingWaitingBarIndicatorElement3);
            this.radWaitingBar3.WaitingSpeed = 20;
            this.radWaitingBar3.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar3.GetChildAt(0))).WaitingSpeed = 20;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar3.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar3.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // segmentedRingWaitingBarIndicatorElement3
            // 
            this.segmentedRingWaitingBarIndicatorElement3.Name = "segmentedRingWaitingBarIndicatorElement3";
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(474, 177);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(88, 88);
            this.radWaitingBar1.TabIndex = 0;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.segmentedRingWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 20;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingSpeed = 20;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // segmentedRingWaitingBarIndicatorElement1
            // 
            this.segmentedRingWaitingBarIndicatorElement1.Name = "segmentedRingWaitingBarIndicatorElement1";
            // 
            // radWaitingBar2
            // 
            this.radWaitingBar2.Location = new System.Drawing.Point(464, 214);
            this.radWaitingBar2.Name = "radWaitingBar2";
            this.radWaitingBar2.Size = new System.Drawing.Size(88, 88);
            this.radWaitingBar2.TabIndex = 0;
            this.radWaitingBar2.Text = "radWaitingBar2";
            this.radWaitingBar2.WaitingIndicators.Add(this.segmentedRingWaitingBarIndicatorElement2);
            this.radWaitingBar2.WaitingSpeed = 20;
            this.radWaitingBar2.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar2.GetChildAt(0))).WaitingSpeed = 20;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar2.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar2.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // segmentedRingWaitingBarIndicatorElement2
            // 
            this.segmentedRingWaitingBarIndicatorElement2.Name = "segmentedRingWaitingBarIndicatorElement2";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 625);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radMenu1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Escritorio";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.radMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton5;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement segmentedRingWaitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar2;
        private Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement segmentedRingWaitingBarIndicatorElement2;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar3;
        private Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement segmentedRingWaitingBarIndicatorElement3;
    }
}
