namespace Gestor_de_imagenes
{
    public partial class FormImagenes : Form
    {
        public FormImagenes()
        {
            InitializeComponent();
           
        }
        private FlowLayoutPanel FLPImagenes = new FlowLayoutPanel();
        private Button btnAñadirImagen = new Button();
        private Button btnEliminarImagen = new Button();
        private Label lblTitulo = new Label();
        private PictureBox ImagenSeleccionada = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración del formulario principal
            this.Text = "Visor de Imágenes";
            this.Size = new Size(800, 600);

            // Creación y caracteristicas del label
            lblTitulo = new Label
            {
                Text = "Miniaturas de Imágenes",
                AutoSize = true,
                Location = new Point(10, 10),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            this.Controls.Add(lblTitulo);

            // Creación y configuración del botón para añadir imágenes
            btnAñadirImagen = new Button
            {
                Text = "Añadir Imagen",
                Location = new Point(10, 40),
                Size = new Size(120, 30)
            };
            //Resgistra cuando se pulse el boton y llama al evento
            btnAñadirImagen.Click += btnAñadirImagen_Click;
            this.Controls.Add(btnAñadirImagen);

            // Creación y configuración del botón para eliminar imágenes
            btnEliminarImagen = new Button
            {
                Text = "Eliminar Imagen",
                Location = new Point(140, 40),
                Size = new Size(120, 30)
            };
            //Resgistra cuando se pulse el boton y llama al evento
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            this.Controls.Add(btnEliminarImagen);

            // Creación y configuración del FlowLayoutPanel para mostrar las imagenes en miniatura
            FLPImagenes = new FlowLayoutPanel
            {
                Location = new Point(10, 80),
                Size = new Size(760, 480),
                AutoScroll = true
            };
            this.Controls.Add(FLPImagenes);
        }
        
        // Evento para el botón de "Añadir Imagen"
        private void btnAñadirImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Dialogo = new OpenFileDialog())
            {
                Dialogo.Filter = "Imágenes|*.jpg;*.png;*.bmp";
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
        // Evento para el botón "Eliminar Imagen"
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (ImagenSeleccionada != null)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la imagen seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo);
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
        // Evento Click para abrir la imagen en tamaño completo
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

        // Método para abrir una nueva ventana que muestre la imagen en tamaño completo
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
