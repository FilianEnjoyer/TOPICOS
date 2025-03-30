
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_AccederBaseDatos
{
    internal class MySQLLenarGrid
    {
        // Variables de conexión a la base de datos MySQL
        private string Servidor = "localhost";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root";
        private string Password = "";

        // Método para llenar los DataGridView con los datos de una tabla en MySQL
        public DataSet llenarGrids(string NomTabla)
        {
            DataSet ds = new DataSet();
            try
            {
                // Cadena de conexión a la base de datos MySQL
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";

                // Uso de la conexión en un bloque using para asegurar su cierre
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                    // Consulta SQL para seleccionar todos los datos de la tabla
                    string sqlQuery = $"select * from {NomTabla}";
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);

                    // Llenado del DataSet con los datos de la tabla
                    adp.Fill(ds, $"{NomTabla}");
                }
            }
            catch (MySqlException Ex)
            {
                // Manejo de excepciones MySQL
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                // Manejo de excepciones generales
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
            //Retorno del DataSet llenado
            return ds;
        }
    }
}