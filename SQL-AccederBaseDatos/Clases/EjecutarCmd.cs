
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
    internal class EjecutarCmd
    {
        // Variables de conexión a la base de datos
        private string Servidor = "MAINPC\\SQLEXPRESS";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";

        // Instancia de la clase LlenarGrid para llenar los DataGridView
        LlenarGrid Llenar = new LlenarGrid();

        // Método para ejecutar comandos SQL
        public (DataSet, SqlCommand) EjecutarComandos(string ConsultaSQL, string NomTabla)
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

                // Creación del comando SQL
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ConsultaSQL;
                cmd.ExecuteNonQuery();

                // Retorno del DataSet llenado y el comando ejecutado
                return (Llenar.llenarGrids(NomTabla), cmd);
            }
            catch (SqlException Ex)
            {
                // Manejo de excepciones SQL
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