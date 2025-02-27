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
    public partial class BotonDobleClick : UserControl
    {
        public BotonDobleClick()
        {
            InitializeComponent();
        }

        private void DobleClick(object sender, MouseEventArgs e)
        {
            int numClicks = e.Clicks;
            if (numClicks == 2) MessageBox.Show("doble");
            else return;
                    
        }

        private void CambioColor(object sender, EventArgs e)
        {
            bt_DobleClick.BackColor = Color.Red;

        }

        private void ColorOriginal(object sender, EventArgs e)
        {
            bt_DobleClick.BackColor = Color.White;
        }
    }
}
