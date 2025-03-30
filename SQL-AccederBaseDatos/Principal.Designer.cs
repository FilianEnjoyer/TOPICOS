namespace SQL_AccederBaseDatos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCrearDB = new System.Windows.Forms.Button();
            this.btCrearTabla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.lblCamposTabla = new System.Windows.Forms.Label();
            this.lblNomTabla = new System.Windows.Forms.Label();
            this.txtNomTabla = new System.Windows.Forms.TextBox();
            this.chkMySQL = new System.Windows.Forms.CheckBox();
            this.chkSQLServer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCrearDB
            // 
            this.btCrearDB.Location = new System.Drawing.Point(169, 243);
            this.btCrearDB.Name = "btCrearDB";
            this.btCrearDB.Size = new System.Drawing.Size(151, 54);
            this.btCrearDB.TabIndex = 0;
            this.btCrearDB.Text = "Crear DB";
            this.btCrearDB.UseVisualStyleBackColor = true;
            this.btCrearDB.Click += new System.EventHandler(this.btCrearDB_Click);
            // 
            // btCrearTabla
            // 
            this.btCrearTabla.Location = new System.Drawing.Point(12, 243);
            this.btCrearTabla.Name = "btCrearTabla";
            this.btCrearTabla.Size = new System.Drawing.Size(151, 54);
            this.btCrearTabla.TabIndex = 1;
            this.btCrearTabla.Text = "Crear Tabla";
            this.btCrearTabla.UseVisualStyleBackColor = true;
            this.btCrearTabla.Click += new System.EventHandler(this.btCrearTabla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtC2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtC1);
            this.groupBox1.Controls.Add(this.txtC3);
            this.groupBox1.Controls.Add(this.lblCamposTabla);
            this.groupBox1.Controls.Add(this.lblNomTabla);
            this.groupBox1.Controls.Add(this.txtNomTabla);
            this.groupBox1.Controls.Add(this.chkMySQL);
            this.groupBox1.Controls.Add(this.chkSQLServer);
            this.groupBox1.Controls.Add(this.btCrearDB);
            this.groupBox1.Controls.Add(this.btCrearTabla);
            this.groupBox1.Location = new System.Drawing.Point(550, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 303);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Campo 3";
            // 
            // txtC2
            // 
            this.txtC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2.Location = new System.Drawing.Point(95, 170);
            this.txtC2.MaxLength = 100;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(231, 26);
            this.txtC2.TabIndex = 37;
            this.txtC2.Text = "Ejemplo: nombre varchar(50)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Campo 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Campo 1 :";
            // 
            // txtC1
            // 
            this.txtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.Location = new System.Drawing.Point(95, 138);
            this.txtC1.MaxLength = 100;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(231, 26);
            this.txtC1.TabIndex = 36;
            this.txtC1.Text = "Ejemplo: NoControl varchar(10)";
            // 
            // txtC3
            // 
            this.txtC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC3.Location = new System.Drawing.Point(95, 202);
            this.txtC3.MaxLength = 100;
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(231, 26);
            this.txtC3.TabIndex = 35;
            this.txtC3.Text = "Ejemplo: carrera int";
            // 
            // lblCamposTabla
            // 
            this.lblCamposTabla.AutoSize = true;
            this.lblCamposTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposTabla.Location = new System.Drawing.Point(8, 106);
            this.lblCamposTabla.Name = "lblCamposTabla";
            this.lblCamposTabla.Size = new System.Drawing.Size(111, 20);
            this.lblCamposTabla.TabIndex = 34;
            this.lblCamposTabla.Text = "Campos tabla:";
            // 
            // lblNomTabla
            // 
            this.lblNomTabla.AutoSize = true;
            this.lblNomTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTabla.Location = new System.Drawing.Point(6, 54);
            this.lblNomTabla.Name = "lblNomTabla";
            this.lblNomTabla.Size = new System.Drawing.Size(108, 20);
            this.lblNomTabla.TabIndex = 33;
            this.lblNomTabla.Text = "Nombre tabla:";
            // 
            // txtNomTabla
            // 
            this.txtNomTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTabla.Location = new System.Drawing.Point(10, 77);
            this.txtNomTabla.MaxLength = 100;
            this.txtNomTabla.Name = "txtNomTabla";
            this.txtNomTabla.Size = new System.Drawing.Size(310, 26);
            this.txtNomTabla.TabIndex = 33;
            this.txtNomTabla.Text = "Ejemplo: Alumnos";
            // 
            // chkMySQL
            // 
            this.chkMySQL.AutoSize = true;
            this.chkMySQL.Location = new System.Drawing.Point(100, 19);
            this.chkMySQL.Name = "chkMySQL";
            this.chkMySQL.Size = new System.Drawing.Size(61, 17);
            this.chkMySQL.TabIndex = 21;
            this.chkMySQL.Text = "MySQL";
            this.chkMySQL.UseVisualStyleBackColor = true;
            // 
            // chkSQLServer
            // 
            this.chkSQLServer.AutoSize = true;
            this.chkSQLServer.Location = new System.Drawing.Point(6, 19);
            this.chkSQLServer.Name = "chkSQLServer";
            this.chkSQLServer.Size = new System.Drawing.Size(78, 17);
            this.chkSQLServer.TabIndex = 20;
            this.chkSQLServer.Text = "SQLServer";
            this.chkSQLServer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Campo 3";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(224, 235);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(116, 54);
            this.btnRefrescar.TabIndex = 30;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(408, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 54);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(286, 175);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 54);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(164, 175);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 54);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(42, 175);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(116, 54);
            this.btnInsertar.TabIndex = 24;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, -45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Campo 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Campo 1 :";
            // 
            // txtCampo3
            // 
            this.txtCampo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampo3.Location = new System.Drawing.Point(116, 123);
            this.txtCampo3.MaxLength = 100;
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(415, 26);
            this.txtCampo3.TabIndex = 21;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampo2.Location = new System.Drawing.Point(116, 86);
            this.txtCampo2.MaxLength = 100;
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(415, 26);
            this.txtCampo2.TabIndex = 20;
            // 
            // txtCampo1
            // 
            this.txtCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampo1.Location = new System.Drawing.Point(116, 49);
            this.txtCampo1.MaxLength = 100;
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(415, 26);
            this.txtCampo1.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrearDB;
        private System.Windows.Forms.Button btCrearTabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMySQL;
        private System.Windows.Forms.CheckBox chkSQLServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCampo3;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label lblNomTabla;
        private System.Windows.Forms.TextBox txtNomTabla;
        private System.Windows.Forms.Label lblCamposTabla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC3;
    }
}

