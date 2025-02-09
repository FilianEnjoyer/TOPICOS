using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Contactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración de la ventana
            this.Text = "Gestion de contactos";
            //Eventos keypress de las textbox
            txtNombre.KeyPress += KeyPressNombre;
            txtNumero.KeyPress += KeyPressNumero;
        }

        // Evento del botón "Añadir Contacto"
        private void btAñadirContacto_Click(object sender, EventArgs e)
        {
            //Verefica que los 3 campos esten llenos
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Por favor, ingresa los 3 campos: Nombre, Correo y Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Añade el contacto a la lista
            string contacto = $"Nombre: {txtNombre.Text} - Correo: {txtCorreo.Text} - Teléfono: {txtNumero.Text}";
            lstContactos.Items.Add(contacto);
            //Limpa las texbox
            txtNombre.Clear();
            txtCorreo.Clear();
            txtNumero.Clear();
        }

        // Evento del botón "Eliminar Contacto"
        private void btEliminarContactos_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado un contacto en la lista
            if (lstContactos.SelectedIndex != -1)
            {
                lstContactos.Items.RemoveAt(lstContactos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StripSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StripAcercade_Click(object sender, EventArgs e)
        {
            string mensaje = "Programa para gestionar contactos.\n\n" +
                             "Permite añadir, eliminar y limpiar contactos de una lista.\n\n" +
                             "Creado por: Cuevas Camarena Alexis \n\n"+
                             "Topicos Avanzados de programacion";
            MessageBox.Show(mensaje, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Evento del botón "Limpiar Lista de Contactos"
        private void btLimpiarListaContactos_Click_1(object sender, EventArgs e)
        {
            // Solicita confirmación antes de limpiar la lista
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas limpiar la lista de contactos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                lstContactos.Items.Clear();
            }
        }
        //Hace que el textbox para nombres solo acepte letras
        private void KeyPressNombre(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 08 || e.KeyChar == 32) //Valida solo los valores Ascii entre 65-90 y 97-122 (Letras minusculas y mayusculas)
            {
            }
            else//Si es codigo Ascii esta fuera del rango permitido no se valida y se omite
            {
                e.KeyChar = (char)0;
            }
        }
        //Hace que el textbox para numeros solo acepte numeros
        private void KeyPressNumero(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 08) //Valida solo los valores Ascii entre 48 y 57 (Numeros)
            {
            }
            else
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
