using Sistema.Negocio.RolLogic;
using Sistema.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Localization;

namespace Sistema.Presentacion
{
    public partial class FrmRol : Telerik.WinControls.UI.RadForm
    {
        private FrmLoading1 loading = null;
        private readonly IRolAccessRepo rolAccess;

        public FrmRol(IRolAccessRepo rolAccess)
        {
            InitializeComponent();
            this.rolAccess = rolAccess;
        }

        private async Task Listar()
        {
            try
            {
                gridRoles.DataSource = await rolAccess.Listar();
                lblTotal.Text = "Total reistros: " + gridRoles.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ShowLoading()
        {
            loading = new FrmLoading1();
            loading.Show();
            loading.BringToFront();
        }

        private void HideLoanding()
        {
            if (loading != null)
            {
                loading.Dispose();
            }
        }

        private void EstilosGridView()
        {
            gridRoles.AllowCellContextMenu = false;
            gridRoles.EnableFiltering = false;
            gridRoles.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            gridRoles.Columns[0].IsVisible = false;

            gridRoles.Columns[1].Width = 200;
            gridRoles.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;

            gridRoles.Columns[2].HeaderText = "Descripción";
            gridRoles.Columns[2].Width = 300;
            gridRoles.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;

            gridRoles.Columns[3].Width = 100;
            gridRoles.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;

            gridRoles.Columns[4].IsVisible = false;


            RadGridLocalizationProvider.CurrentProvider = new MySpanishRadGridLocalizationProvider();
        }

        private async void FrmRol_Load(object sender, EventArgs e)
        {
            #region LayoutControlConfigurations    

            radLayoutControl1.AllowCustomize = false;

            #endregion

            ShowLoading();
            await Listar();
            HideLoanding();

            EstilosGridView();
        }

        private void gridRoles_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
