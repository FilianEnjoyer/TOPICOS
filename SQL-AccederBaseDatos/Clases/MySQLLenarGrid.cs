
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
        private string Servidor = "localhost";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root";
        private string Password = "";
        public DataSet llenarGrids(string NomTabla)
        {
            DataSet ds = new DataSet();
            try
            {
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                    string sqlQuery = $"select * from {NomTabla}";
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);

                    adp.Fill(ds, $"{NomTabla}");
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
            return ds;
        }
    }
}