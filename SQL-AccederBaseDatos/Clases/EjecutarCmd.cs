
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
        private string Servidor = "MAINPC\\SQLEXPRESS";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";
        LlenarGrid Llenar = new LlenarGrid();
        public (DataSet, SqlCommand) EjecutarComandos(string ConsultaSQL, string NomTabla)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ConsultaSQL;
                cmd.ExecuteNonQuery();


                return (Llenar.llenarGrids(NomTabla), cmd);

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
                return (null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
                return (null, null);
            }
        }
        
    }
}