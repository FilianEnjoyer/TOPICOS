using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTopicosV1
{
    public partial class txtBoxLetras : UserControl
    {
        public txtBoxLetras()
        {
            InitializeComponent();
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
            {

            }
            else e.KeyChar = (char)0;
        }
    }
}
