using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_AccederBaseDatos
{
    public partial class FromAyuda : Form
    {
        public FromAyuda()
        {
            InitializeComponent();
        }

        private void btnEjemploCrearTabla_Click(object sender, EventArgs e)
        {
            ImagenCrearTabla imagenCrearTabla = new ImagenCrearTabla();
            imagenCrearTabla.Visible = true;
        }

        private void btnInserEj_Click(object sender, EventArgs e)
        {
            ImagenInsetar imagenInsertar = new ImagenInsetar();
            imagenInsertar.Visible = true;

        }

        private void btActEj_Click(object sender, EventArgs e)
        {
            ImagenActualizar imagenActualizar = new ImagenActualizar();
            imagenActualizar.Visible = true;
        }

        private void btBorEj_Click(object sender, EventArgs e)
        {
            ImagenBorrar imagenBorrar = new ImagenBorrar();
            imagenBorrar.Visible = true;
        }

        private void btBusEj_Click(object sender, EventArgs e)
        {
            ImagenBuscar imagenBuscar = new ImagenBuscar();
            imagenBuscar.Visible = true;
        }

        private void btRefEj_Click(object sender, EventArgs e)
        {
            ImagenRefrescar imagenRefrescar = new ImagenRefrescar();
            imagenRefrescar.Visible = true;
        }
    }
}
    