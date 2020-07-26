using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Services
{
    public interface IFormOpener
    {
        Form ShowModelessForm<TForm>() where TForm : Form;
        DialogResult ShowModalForm<TForm>() where TForm : Form;
    }
}
