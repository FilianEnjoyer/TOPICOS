namespace BibliotecaTopicosV1
{
    partial class txtBoxNumeros
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Numeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Numeros
            // 
            this.Txt_Numeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Numeros.Location = new System.Drawing.Point(0, 0);
            this.Txt_Numeros.Multiline = true;
            this.Txt_Numeros.Name = "Txt_Numeros";
            this.Txt_Numeros.Size = new System.Drawing.Size(127, 35);
            this.Txt_Numeros.TabIndex = 0;
            this.Txt_Numeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_Numeros);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(127, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Numeros;
    }
}
