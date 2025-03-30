using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_AccederBaseDatos.Clases
{
    internal class MostrarTabla
    {
        // Método para crear y mostrar un DataGridView con los datos de un DataSet
        public (Label, DataGridView) CrearYMostrarDataGridView(DataSet ds, string nombreTabla)
        {
            // Creación de un nuevo DataGridView
            DataGridView dgv = new DataGridView
            {
                DataSource = ds.Tables[0],
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Location = new Point(10, 325),
                Size = new Size(800, 200),
                Name = "dgv" + nombreTabla,
                Visible = true
            };

            // Creación de un nuevo Label para mostrar el nombre de la tabla
            Label lbl = new Label
            {
                Text = "Tabla: " + nombreTabla,
                Location = new Point(10, dgv.Location.Y - 20),
                AutoSize = true,
                Visible = true
            };

            // Retorno del Label y el DataGridView creados
            return (lbl, dgv);
        }
    }
}
