using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_AccederBaseDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCrearDB_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Server=LAP-ALEX\\SQLEXPRESS;" + "Database=master;" + "User Id=sa;" + "Password=FilianEnjoyer";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CREATE DATABASE ESCOLAR";
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btCrearTabla_Click(object sender, EventArgs e)
        {
         
        }
    }
}
