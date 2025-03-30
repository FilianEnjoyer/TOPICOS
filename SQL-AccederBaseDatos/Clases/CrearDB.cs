
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
        // Variables de conexión a la base de datos
        private string Servidor = "MAINPC\\SQLEXPRESS";
        private string Basedatos = "master";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";

        // Método para crear una base de datos
        public void CrearBase(string DB)
        {
            try
            {
                // Cadena de conexión a la base de datos
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";
                // Creación y apertura de la conexión
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                // Comando SQL para crear la base de datos
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"CREATE DATABASE {DB}";
                cmd.ExecuteNonQuery();
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
        }
    }
}