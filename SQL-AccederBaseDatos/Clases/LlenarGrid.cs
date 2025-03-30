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
    internal class LlenarGrid
    {
        private string Servidor = "MAINPC\\SQLEXPRESS";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "FilianEnjoyer";
        public DataSet llenarGrids(string NomTabla)
        {
            DataSet ds = new DataSet();
            try
            {
                string strConn = $"Server={Servidor};" +
                                 $"Database={Basedatos};" +
                                 $"User Id={UsuarioId};" +
                                 $"Password={Password}";

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    string sqlQuery = $"select * from {NomTabla}";
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);

                    adp.Fill(ds, $"{NomTabla}");
                }
            }
            catch (SqlException Ex)
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

