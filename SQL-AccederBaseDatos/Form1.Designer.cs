namespace SQL_AccederBaseDatos
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btCrearDB
            // 
            this.btCrearDB.Location = new System.Drawing.Point(675, 53);
            this.btCrearDB.Name = "btCrearDB";
            this.btCrearDB.Size = new System.Drawing.Size(75, 23);
            this.btCrearDB.TabIndex = 0;
            this.btCrearDB.Text = "Crear DB";
            this.btCrearDB.UseVisualStyleBackColor = true;
            this.btCrearDB.Click += new System.EventHandler(this.btCrearDB_Click);
            // 
            // btCrearTabla
            // 
            this.btCrearTabla.Location = new System.Drawing.Point(675, 95);
            this.btCrearTabla.Name = "btCrearTabla";
            this.btCrearTabla.Size = new System.Drawing.Size(75, 23);
            this.btCrearTabla.TabIndex = 1;
            this.btCrearTabla.Text = "Crear Tabla";
            this.btCrearTabla.UseVisualStyleBackColor = true;
            this.btCrearTabla.Click += new System.EventHandler(this.btCrearTabla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCrearTabla);
            this.Controls.Add(this.btCrearDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrearDB;
        private System.Windows.Forms.Button btCrearTabla;
    }
}

