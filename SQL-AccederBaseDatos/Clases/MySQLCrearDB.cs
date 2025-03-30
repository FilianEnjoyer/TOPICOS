
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
    internal class MySQLCrearDB
    {
        private string Servidor = "localhost";
        private string Basedatos = "sys";
        private string UsuarioId = "root";
        private string Password = "";
        public void CrearBase(string DB)
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
                cmd.CommandText = $"CREATE DATABASE {DB}";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }
    }
}