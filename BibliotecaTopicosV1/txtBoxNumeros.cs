using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTopicosV1
{
    public partial class txtBoxNumeros: UserControl
    {
        public txtBoxNumeros()
        {
            InitializeComponent();
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)  e.KeyChar = (char)0;
        }
    }
}
