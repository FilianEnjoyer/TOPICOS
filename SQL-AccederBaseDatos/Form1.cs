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
using MySql.Data.MySqlClient;

namespace SQL_AccederBaseDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EjecutarCmd cmd = new EjecutarCmd();
        MySQLEjecutarCmd MySqlCmd = new MySQLEjecutarCmd();
        CrearDB CrearDB = new CrearDB();
        MySQLCrearDB MySQLCrearDB = new MySQLCrearDB();
        LlenarGrid Llenar = new LlenarGrid();
        MySQLLenarGrid MySQLLlenar = new MySQLLenarGrid();
        private void btCrearDB_Click(object sender, EventArgs e)
        {
            if(chkSQLServer.Checked)
            {
                CrearDB.CrearBase("ESCOLAR");
            }
            else if (chkMySQL.Checked)
            {
                MySQLCrearDB.CrearBase("ESCOLAR");
            }
            
        }
        DataSet ds = new DataSet();
        SqlCommand comando = new SqlCommand();
        DataSet MySQLds = new DataSet();
        MySqlCommand MySQLcomando = new MySqlCommand();
        private void btCrearTabla_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                 var (ds, comando) = cmd.EjecutarComandos("CREATE TABLE " + "Alumnos (NoControl varchar(10), nombre varchar(50), carrera int)");
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                 var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos("CREATE TABLE " + "Alumnos (NoControl varchar(10), nombre varchar(50), carrera int)");
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (ds, comando) = cmd.EjecutarComandos("INSERT INTO " +
                            "Alumnos (NoControl, nombre, carrera) " +
                            "VALUES ('" + txtNoControl.Text +
                            "', '" + txtNombre.Text +
                            "', " + txtCarrera.Text + ")");
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos("INSERT INTO " +
                            "Alumnos (NoControl, nombre, carrera) " +
                            "VALUES ('" + txtNoControl.Text +
                            "', '" + txtNombre.Text +
                            "', " + txtCarrera.Text + ")");
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (ds, comando) = cmd.EjecutarComandos($"UPDATE Alumnos SET " +
                      $"nombre = '{txtNombre.Text}', " +
                      $"carrera = {txtCarrera.Text} " +
                      $"WHERE NoControl = '{txtNoControl.Text}'");
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos($"UPDATE Alumnos SET " +
                      $"nombre = '{txtNombre.Text}', " +
                      $"carrera = {txtCarrera.Text} " +
                      $"WHERE NoControl = '{txtNoControl.Text}'");
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (ds, comando) = cmd.EjecutarComandos($"DELETE FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'");
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos($"DELETE FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'");
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }

                var (ds, comando) = cmd.EjecutarComandos($"SELECT * FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'");
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["nombre"].ToString();
                    txtCarrera.Text = reader["carrera"].ToString();

                }
                else
                {
                    MessageBox.Show("Alumno no encontrado.");
                }
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                if (txtNoControl.Text == null)
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                    return;
                }
                var (MySQLds, MySQLcomando) = MySqlCmd.EjecutarComandos(($"SELECT * FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'"));
                MySqlDataReader reader = MySQLcomando.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["nombre"].ToString();
                    txtCarrera.Text = reader["carrera"].ToString();

                }
                else
                {
                    MessageBox.Show("Alumno no encontrado.");
                }
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                ds = Llenar.llenarGrids();
                dgvAlumnos.DataSource = ds.Tables[0];
                dgvAlumnos.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                MySQLds = MySQLLlenar.llenarGrids();
                dgvAlumnos.DataSource = MySQLds.Tables[0];
                dgvAlumnos.Refresh();
            }
        }
    }
}
