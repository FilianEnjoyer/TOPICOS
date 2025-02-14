namespace Gestor_de_imagenes
{
    public partial class FormImagenes : Form
    {
        public FormImagenes()
        {
            InitializeComponent();
           
        }
        private FlowLayoutPanel FLPImagenes = new FlowLayoutPanel();
        private Button btnA�adirImagen = new Button();
        private Button btnEliminarImagen = new Button();
        private Label lblTitulo = new Label();
        private PictureBox ImagenSeleccionada = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuraci�n del formulario principal
            this.Text = "Visor de Im�genes";
            this.Size = new Size(800, 600);

            // Creaci�n y caracteristicas del label
            lblTitulo = new Label
            {
                Text = "Miniaturas de Im�genes",
                AutoSize = true,
                Location = new Point(10, 10),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            this.Controls.Add(lblTitulo);

            // Creaci�n y configuraci�n del bot�n para a�adir im�genes
            btnA�adirImagen = new Button
            {
                Text = "A�adir Imagen",
                Location = new Point(10, 40),
                Size = new Size(120, 30)
            };
            //Resgistra cuando se pulse el boton y llama al evento
            btnA�adirImagen.Click += btnA�adirImagen_Click;
            this.Controls.Add(btnA�adirImagen);

            // Creaci�n y configuraci�n del bot�n para eliminar im�genes
            btnEliminarImagen = new Button
            {
                Text = "Eliminar Imagen",
                Location = new Point(140, 40),
                Size = new Size(120, 30)
            };
            //Resgistra cuando se pulse el boton y llama al evento
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            this.Controls.Add(btnEliminarImagen);

            // Creaci�n y configuraci�n del FlowLayoutPanel para mostrar las imagenes en miniatura
            FLPImagenes = new FlowLayoutPanel
            {
                Location = new Point(10, 80),
                Size = new Size(760, 480),
                AutoScroll = true
            };
            this.Controls.Add(FLPImagenes);
        }
        
        // Evento para el bot�n de "A�adir Imagen"
        private void btnA�adirImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Dialogo = new OpenFileDialog())
            {
                Dialogo.Filter = "Im�genes|*.jpg;*.png;*.bmp";
                Dialogo.Multiselect = true;

                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    foreach (string rutaImagen in Dialogo.FileNames)
                    {
                        try
                        {
                            using (Image imgOriginal = Image.FromFile(rutaImagen))
                            {
                                Image miniatura = imgOriginal.GetThumbnailImage(100, 100, () => false, IntPtr.Zero);
                                PictureBox imagen = new PictureBox
                                {
                                    Image = miniatura,
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Width = 100,
                                    Height = 100,
                                    Cursor = Cursors.Hand,
                                    Tag = rutaImagen
                                };
                                imagen.Click += AbrirImagenCompleta_Click;
                                imagen.MouseDown += EliminarImagen_MouseDown;
                                FLPImagenes.Controls.Add(imagen);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al agregar la imagen: {Path.GetFileName(rutaImagen)}\n{ex.Message}");
                        }
                    }
                }
            }
        }
        // Evento para el bot�n "Eliminar Imagen"
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (ImagenSeleccionada != null)
            {
                DialogResult result = MessageBox.Show("�Desea eliminar la imagen seleccionada?", "Confirmar eliminaci�n", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FLPImagenes.Controls.Remove(ImagenSeleccionada);
                    ImagenSeleccionada.Image.Dispose();
                    ImagenSeleccionada.Dispose();
                    ImagenSeleccionada = null;
                }
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada para eliminar. Haga clic derecho sobre la miniatura para seleccionarla.");
            }
        }
        // Evento Click para abrir la imagen en tama�o completo
        private void AbrirImagenCompleta_Click(object sender, EventArgs e)
        {
            // Solo se abre la imagen si se hace clic izquierdo
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                PictureBox pb = sender as PictureBox;
                string rutaImagen = pb.Tag.ToString();

                try
                {
                    // Cargar la imagen completa
                    Image imagenCompleta = Image.FromFile(rutaImagen);
                    AbrirImagenCompleta(rutaImagen, imagenCompleta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir la imagen:\n{ex.Message}");
                }
            }
        }
        // Evento MouseDown para seleccionar una miniatura (clic derecho)
        private void EliminarImagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Quitar resaltado de la miniatura previamente seleccionada
                if (ImagenSeleccionada != null)
                {
                    ImagenSeleccionada.BorderStyle = BorderStyle.None;
                }
                ImagenSeleccionada = sender as PictureBox;
                ImagenSeleccionada.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // M�todo para abrir una nueva ventana que muestre la imagen en tama�o completo
        private void AbrirImagenCompleta(string rutaArchivo, Image imagen)
        {
            Form formImagen = new Form
            {
                Text = Path.GetFileName(rutaArchivo),
                Size = new Size(800, 600),
                StartPosition = FormStartPosition.CenterParent
            };

            PictureBox pbImagenCompleta = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = imagen,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            formImagen.Controls.Add(pbImagenCompleta);

            // Liberar recursos de la imagen al cerrar la ventana
            formImagen.FormClosed += (s, args) =>
            {
                pbImagenCompleta.Image.Dispose();
            };

            formImagen.Show();
        }
    }
}
