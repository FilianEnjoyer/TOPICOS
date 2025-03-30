using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_AccederBaseDatos
{
    internal class LlenarGrid
    {
        // Variables de conexión a la base de datos
        private string Servidor = "MAINPC\\SQLEXPRESS";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";

        // Método para llenar los DataGridView con los datos de una tabla
        public DataSet llenarGrids(string NomTabla)
        {
            DataSet ds = new DataSet();
            try
            {
                // Cadena de conexión a la base de datos
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";

                // Uso de la conexión en un bloque using para asegurar su cierre
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    // Consulta SQL para seleccionar todos los datos de la tabla
                    string sqlQuery = $"select * from {NomTabla}";
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);

                    // Llenado del DataSet con los datos de la tabla
                    adp.Fill(ds, $"{NomTabla}");
                }
            }
            catch (SqlException Ex)
            {
                // Manejo de excepciones SQL
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                // Manejo de excepciones generales
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
            return ds;
        }
    }
}

