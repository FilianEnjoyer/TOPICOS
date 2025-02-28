using BibliotecaTopicosV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ValidarRFC validarRFC = new ValidarRFC();

        private void CajaTexto_TextChanged(object sender, EventArgs e)
        {
            ValidacionInPut validacionInPut = new ValidacionInPut();
            validacionInPut.SoloLetras(CajaTexto.Text);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Validar_Click(object sender, EventArgs e)
        { 
            ValidacionInPut validacion = new ValidacionInPut();
            bool validar = validacion.SoloLetras(CajaTexto.Text);
            if (validar==true)
            {
                MessageBox.Show("Solo hay letras en la caja de texto");
            }
            else
            {
                MessageBox.Show("No contiene solo letras");
            }
        }

        private void bt_ValidarRFC_Click(object sender, EventArgs e)
        {
            
            bool validar = validarRFC.EsRFCValido(txtRFC.Text);
            if (validar == true)
            {
                MessageBox.Show("RFC Correcto");
                txtRFC.Text = validarRFC.CorregirRFC(txtRFC.Text);
            }
            else
            {
                MessageBox.Show("RFC Incorrecto debe tener el formato: AAAA######XXX");
                txtRFC.Clear();
            }
        }

        private void CorregirRFC(object sender, KeyPressEventArgs e)
        {

            
        }

    }
}
