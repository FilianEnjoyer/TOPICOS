
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
    internal class CrearDB
    {
        private string Servidor = "LAP-ALEX\\SQLEXPRESS";
        private string Basedatos = "master";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";
        public void CrearBase(string DB)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database=master;" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"CREATE DATABASE {DB}";
                cmd.ExecuteNonQuery();

                


            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
    }
}