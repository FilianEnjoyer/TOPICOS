namespace Gestion_Contactos
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
            this.btAñadirContacto = new System.Windows.Forms.Button();
            this.btLimpiarListaContactos = new System.Windows.Forms.Button();
            this.btEliminarContactos = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.StripAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAñadirContacto
            // 
            this.btAñadirContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirContacto.Location = new System.Drawing.Point(28, 60);
            this.btAñadirContacto.Name = "btAñadirContacto";
            this.btAñadirContacto.Size = new System.Drawing.Size(318, 48);
            this.btAñadirContacto.TabIndex = 0;
            this.btAñadirContacto.Text = "Añadir contactos";
            this.btAñadirContacto.UseVisualStyleBackColor = true;
            this.btAñadirContacto.DockChanged += new System.EventHandler(this.Form1_Load);
            this.btAñadirContacto.Click += new System.EventHandler(this.btAñadirContacto_Click);
            // 
            // btLimpiarListaContactos
            // 
            this.btLimpiarListaContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarListaContactos.Location = new System.Drawing.Point(495, 117);
            this.btLimpiarListaContactos.Name = "btLimpiarListaContactos";
            this.btLimpiarListaContactos.Size = new System.Drawing.Size(133, 48);
            this.btLimpiarListaContactos.TabIndex = 1;
            this.btLimpiarListaContactos.Text = "Limpiar lista de contactos";
            this.btLimpiarListaContactos.UseVisualStyleBackColor = true;
            this.btLimpiarListaContactos.DockChanged += new System.EventHandler(this.Form1_Load);
            this.btLimpiarListaContactos.Click += new System.EventHandler(this.btLimpiarListaContactos_Click_1);
            // 
            // btEliminarContactos
            // 
            this.btEliminarContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarContactos.Location = new System.Drawing.Point(495, 49);
            this.btEliminarContactos.Name = "btEliminarContactos";
            this.btEliminarContactos.Size = new System.Drawing.Size(133, 48);
            this.btEliminarContactos.TabIndex = 2;
            this.btEliminarContactos.Text = "Eliminar Contacto";
            this.btEliminarContactos.UseVisualStyleBackColor = true;
            this.btEliminarContactos.DockChanged += new System.EventHandler(this.Form1_Load);
            this.btEliminarContactos.Click += new System.EventHandler(this.btEliminarContactos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE";
            this.label1.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NUMERO";
            this.label2.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(127, 193);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(219, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CORREO";
            this.label3.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(127, 167);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(219, 20);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripSalir,
            this.StripAcercade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripSalir
            // 
            this.StripSalir.Name = "StripSalir";
            this.StripSalir.Size = new System.Drawing.Size(41, 20);
            this.StripSalir.Text = "Salir";
            this.StripSalir.Click += new System.EventHandler(this.StripSalir_Click);
            // 
            // StripAcercade
            // 
            this.StripAcercade.Name = "StripAcercade";
            this.StripAcercade.Size = new System.Drawing.Size(71, 20);
            this.StripAcercade.Text = "Acerca de";
            this.StripAcercade.Click += new System.EventHandler(this.StripAcercade_Click);
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(28, 223);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(620, 316);
            this.lstContactos.TabIndex = 10;
            this.lstContactos.SelectedIndexChanged += new System.EventHandler(this.lstContactos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 554);
            this.Controls.Add(this.lstContactos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btEliminarContactos);
            this.Controls.Add(this.btLimpiarListaContactos);
            this.Controls.Add(this.btAñadirContacto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAñadirContacto;
        private System.Windows.Forms.Button btLimpiarListaContactos;
        private System.Windows.Forms.Button btEliminarContactos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripSalir;
        private System.Windows.Forms.ToolStripMenuItem StripAcercade;
        private System.Windows.Forms.ListBox lstContactos;
    }
}

