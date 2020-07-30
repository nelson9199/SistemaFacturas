using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema.Presentacion
{
    public partial class FrmLoading2 : Telerik.WinControls.UI.RadForm
    {
        public FrmLoading2()
        {
            InitializeComponent();
        }

        private void FrmLoading2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Spinner_1s_200px;
        }
    }
}
