namespace Tests
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
            this.CajaTexto = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.bt_ValidarRFC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CajaTexto
            // 
            this.CajaTexto.Location = new System.Drawing.Point(70, 63);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(100, 20);
            this.CajaTexto.TabIndex = 0;
            this.CajaTexto.TextChanged += new System.EventHandler(this.CajaTexto_TextChanged);
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(190, 63);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(75, 23);
            this.Validar.TabIndex = 1;
            this.Validar.Text = "ValidarInput";
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.Validar_Click);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(70, 122);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 2;
            this.txtRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CorregirRFC);
            // 
            // bt_ValidarRFC
            // 
            this.bt_ValidarRFC.Location = new System.Drawing.Point(190, 118);
            this.bt_ValidarRFC.Name = "bt_ValidarRFC";
            this.bt_ValidarRFC.Size = new System.Drawing.Size(75, 23);
            this.bt_ValidarRFC.TabIndex = 3;
            this.bt_ValidarRFC.Text = "ValidarRFC";
            this.bt_ValidarRFC.UseVisualStyleBackColor = true;
            this.bt_ValidarRFC.Click += new System.EventHandler(this.bt_ValidarRFC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ValidarRFC);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.CajaTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaTexto;
        private System.Windows.Forms.Button Validar;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Button bt_ValidarRFC;
    }
}

