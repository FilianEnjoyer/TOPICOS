
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
        // Variables de conexión a la base de datos MySQL
        private string Servidor = "localhost";
        private string Basedatos = "sys";
        private string UsuarioId = "root";
        private string Password = "";

        // Método para crear una base de datos en MySQL
        public void CrearBase(string DB)
        {
            try
            {
                // Cadena de conexión a la base de datos MySQL
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";

                // Creación y apertura de la conexión
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();
                // Comando SQL para crear la base de datos
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"CREATE DATABASE {DB}";
                cmd.ExecuteNonQuery();
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
        }
    }
}