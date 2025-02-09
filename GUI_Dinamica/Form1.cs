using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Dinamica
{
    public partial class Form1 : Form
    {
        private Button btnAddControls;
        private List<Button> dynamicButtons = new List<Button>();
        private List<TextBox> dynamicTextBoxes = new List<TextBox>();
        private int controlCounter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración de la ventana
            this.Text = "Creación Dinámica de Controles";
            this.Size = new Size(400, 400);

            // Botón para agregar controles dinámicamente
            btnAddControls = new Button();
            btnAddControls.Text = "Agregar Controles";
            btnAddControls.Location = new Point(20, 20);
            btnAddControls.Click += new EventHandler(AddControls);
            this.Controls.Add(btnAddControls);
        }

        private void AddControls(object sender, EventArgs e)
        {
            // Crear un nuevo botón
            Button newButton = new Button();
            newButton.Text = "Botón " + controlCounter;
            newButton.Size = new Size(100, 30);
            newButton.Location = new Point(20, 60 + dynamicButtons.Count * 40);
            newButton.Click += DynamicButtonClick;
            

            // Crear una nueva caja de texto
            TextBox newTextBox = new TextBox();
            newTextBox.Size = new Size(150, 30);
            newTextBox.Location = new Point(140, 60 + dynamicTextBoxes.Count * 40);

            dynamicTextBoxes.Add(newTextBox);
            dynamicButtons.Add(newButton);

            this.Controls.Add(newTextBox);
            this.Controls.Add(newButton);
            newTextBox.KeyPress += DynamicKeyPress;
            newTextBox.Tag = controlCounter;

            controlCounter++;
        }
        private void DynamicButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("Has presionado: " + clickedButton.Text);
        }
        private void DynamicKeyPress (object sender, KeyPressEventArgs e)
        {
            TextBox pressedTextBox = sender as TextBox;
            int num = (int) pressedTextBox.Tag;
            if (num%2 == 0) //Se obtiene el modulo del Tag, si es igual a 0 la textbox es par y es diferente de 0 es impar
            {
                //Es par
               if(e.KeyChar >= 65 && e.KeyChar<=90 || e.KeyChar >= 97 && e.KeyChar <= 122) //Valida solo los valores Ascii entre 65-90 y 97-122 (Letras minusculas y mayusculas)
                {
                }
                else//Si es codigo Ascii esta fuera del rango permitido no se valida y se omite
                {
                    e.KeyChar = (char)0;
                }
            }
            else
            {
                //No es par
                if (e.KeyChar >= 48 && e.KeyChar <= 57) //Valida solo los valores Ascii entre 48 y 57 (Numeros)
                {
                }
                else
                {
                    e.KeyChar = (char)0;
                }
            }
            

        }

    }
}
