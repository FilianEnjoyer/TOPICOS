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
using SQL_AccederBaseDatos.Clases;

namespace SQL_AccederBaseDatos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        EjecutarCmd cmd = new EjecutarCmd();
        MySQLEjecutarCmd MySqlCmd = new MySQLEjecutarCmd();
        CrearDB CrearDB = new CrearDB();
        MySQLCrearDB MySQLCrearDB = new MySQLCrearDB();
        LlenarGrid Llenar = new LlenarGrid();
        MySQLLenarGrid MySQLLlenar = new MySQLLenarGrid();
        MostrarTabla MostrarTabla = new MostrarTabla();
        private void btCrearDB_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
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
        private void OcultarDataGrids()
        {
            foreach (var dgv in this.Controls.OfType<DataGridView>())
            {
                dgv.Visible = false;
            }
            foreach (var lbl in this.Controls.OfType<Label>().Where(l => l.Text.StartsWith("Tabla: ")))
            {
                lbl.Visible = false;
            }
        }
        private void btCrearTabla_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                try
                {
                    if (txtNomTabla.Text == "Ejemplo: Alumnos" || txtC1.Text == "Ejemplo: NoControl varchar(10)" || txtC2.Text == "Ejemplo: nombre varchar(50)" || txtC3.Text == "Ejemplo: carrera int")
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos.");
                        return;
                    }
                    else if (txtNomTabla.Text == null || txtC1.Text == null || txtC2.Text == null || txtC3.Text == null)
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos."); return;
                    }
                    else if (txtNomTabla.Text == "" || txtC1.Text == "" || txtC2.Text == "" || txtC3.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos."); return;
                    }
                    else
                    {
                        OcultarDataGrids();
                        var (ds, comando) = cmd.EjecutarComandos("CREATE TABLE " + $"{txtNomTabla.Text} ({txtC1.Text}, {txtC2.Text}, {txtC3.Text})", $"{txtNomTabla.Text}");
                        var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                        this.Controls.Add(lbl);
                        this.Controls.Add(dgv);
                        dgv.Refresh();
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
            }
            else if (chkMySQL.Checked)
            {
                try
                {
                    if (txtNomTabla.Text == "Ejemplo: Alumnos" || txtC1.Text == "Ejemplo: NoControl varchar(10)" || txtC2.Text == "Ejemplo: nombre varchar(50)" || txtC3.Text == "Ejemplo: carrera int")
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos.");
                        return;
                    }
                    else if (txtNomTabla.Text == null || txtC1.Text == null || txtC2.Text == null || txtC3.Text == null)
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos."); return;
                    }
                    else if (txtNomTabla.Text == "" || txtC1.Text == "" || txtC2.Text == "" || txtC3.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la tabla y los campos."); return;
                    }
                    else
                    {
                        OcultarDataGrids();
                        var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos("CREATE TABLE " + $"{txtNomTabla.Text} ({txtC1.Text}, {txtC2.Text}, {txtC3.Text})", $"{txtNomTabla.Text}");
                        var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(MySQLds, $"MySQL {txtNomTabla.Text}");
                        this.Controls.Add(lbl);
                        this.Controls.Add(dgv);
                        dgv.Refresh();
                    }
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    
                    var (ds, comando) = cmd.EjecutarComandos("INSERT INTO " +
                                $"{txtNomTabla.Text} ({txtC1.Text}, {txtC2.Text}, {txtC3.Text}) " +
                                "VALUES ('" + txtCampo1.Text +
                                "', '" + txtCampo2.Text +
                                "', " + txtCampo3.Text + ")", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error en el sistema: " + Ex.Message);
                }
            }
            else if (chkMySQL.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    
                    var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos("INSERT INTO " +
                                $"{txtNomTabla.Text} ({txtC1.Text}, {txtC2.Text}, {txtC3.Text}) " +
                                "VALUES ('" + txtCampo1.Text +
                                "', '" + txtCampo2.Text +
                                "', " + txtCampo3.Text + ")", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(MySQLds, $"MySQL {txtNomTabla.Text}");
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }
                    var (ds, comando) = cmd.EjecutarComandos($"UPDATE {txtNomTabla.Text} SET " +
                          $"{txtC2.Text} = '{txtCampo2.Text}', " +
                          $"{txtC3.Text} = {txtCampo3.Text} " +
                          $"WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error en el sistema: " + Ex.Message);
                }
            }
            else if (chkMySQL.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }
                    var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos($"UPDATE {txtNomTabla.Text} SET " +
                          $"{txtC2.Text} = '{txtCampo2.Text}', " +
                          $"{txtC3.Text} = {txtCampo3.Text} " +
                          $"WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(MySQLds, $"MySQL {txtNomTabla.Text}");
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }
                    var (ds, comando) = cmd.EjecutarComandos($"DELETE FROM {txtNomTabla.Text} WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error en el sistema: " + Ex.Message);
                }
            }
            else if (chkMySQL.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }
                    var (MySQLds, MySLcomando) = MySqlCmd.EjecutarComandos($"DELETE FROM {txtNomTabla.Text} WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(MySQLds, $"MySQL {txtNomTabla.Text}");
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }

                    var (ds, comando) = cmd.EjecutarComandos($"SELECT * FROM {txtNomTabla.Text} WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCampo2.Text = reader[txtC2.Text].ToString();
                        txtCampo3.Text = reader[txtC3.Text].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Alumno no encontrado.");
                    }
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error en el sistema: " + Ex.Message);
                }
            }
            else if (chkMySQL.Checked)
            {
                try
                {
                    OcultarDataGrids();
                    if (txtCampo1.Text == null)
                    {
                        MessageBox.Show("Ingrese el NoControl del alumno a eliminar.");
                        return;
                    }
                    var (MySQLds, MySQLcomando) = MySqlCmd.EjecutarComandos($"SELECT * FROM {txtNomTabla.Text} WHERE {txtC1.Text} = '{txtCampo1.Text}'", $"{txtNomTabla.Text}");
                    MySqlDataReader reader = MySQLcomando.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCampo2.Text = reader[txtC2.Text].ToString();
                        txtCampo3.Text = reader[txtC3.Text].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Alumno no encontrado.");
                    }
                    var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(MySQLds, $"MySQL {txtNomTabla.Text}");
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
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
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (chkSQLServer.Checked)
            {
                OcultarDataGrids();
                DataSet ds = Llenar.llenarGrids($"{txtNomTabla.Text}");
                var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, txtNomTabla.Text);
                this.Controls.Add(lbl);
                this.Controls.Add(dgv);
                dgv.Refresh();
            }
            else if (chkMySQL.Checked)
            {
                OcultarDataGrids();
                DataSet ds = MySQLLlenar.llenarGrids($"{txtNomTabla.Text}");
                var (lbl, dgv) = MostrarTabla.CrearYMostrarDataGridView(ds, $"MySQL {txtNomTabla.Text}");
                this.Controls.Add(lbl);
                this.Controls.Add(dgv);
                dgv.Refresh();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromAyuda Ayuda = new FromAyuda();
            Ayuda.Show();
        }
    }
}
