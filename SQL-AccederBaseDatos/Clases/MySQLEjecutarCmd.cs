
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
        // Variables de conexión a la base de datos MySQL
        private string Servidor = "localhost";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root";
        private string Password = "";

        // Instancia de la clase MySQLLenarGrid para llenar los DataGridView
        MySQLLenarGrid Llenar = new MySQLLenarGrid();

        // Método para ejecutar comandos SQL en MySQL
        public (DataSet, MySqlCommand) EjecutarComandos(string ConsultaSQL, string NomTabla)
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

                // Creación del comando SQL
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ConsultaSQL;
                cmd.ExecuteNonQuery();

                // Retorno del DataSet llenado y el comando ejecutado
                return (Llenar.llenarGrids(NomTabla), cmd);
            }
            catch (MySqlException Ex)
            {
                // Manejo de excepciones MySQL
                MessageBox.Show(Ex.Message);
                return (null, null);
            }
            catch (Exception Ex)
            {
                // Manejo de excepciones generales
                MessageBox.Show("Error en el sistema: " + Ex.Message);
                return (null, null);
            }
        }
    }
}