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
    public partial class FrmUsuario : Telerik.WinControls.UI.RadTabbedForm
    {
        public FrmUsuario()
        {
            InitializeComponent();

            this.AllowAero = false;
        }
    }
}
