
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
    internal class MySQLEjecutarCmd
    {
        private string Servidor = "localhost";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root";
        private string Password = "";
        MySQLLenarGrid Llenar = new MySQLLenarGrid();
        public (DataSet, MySqlCommand) EjecutarComandos(string ConsultaSQL)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";


                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ConsultaSQL;
                cmd.ExecuteNonQuery();


                return (Llenar.llenarGrids(), cmd);

            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
                return (null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
                return (null, null);
            }
        }
    }
}