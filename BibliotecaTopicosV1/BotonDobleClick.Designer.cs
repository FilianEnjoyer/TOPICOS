namespace BibliotecaTopicosV1
{
    partial class BotonDobleClick
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
            this.bt_DobleClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_DobleClick
            // 
            this.bt_DobleClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_DobleClick.Location = new System.Drawing.Point(0, 0);
            this.bt_DobleClick.Name = "bt_DobleClick";
            this.bt_DobleClick.Size = new System.Drawing.Size(119, 49);
            this.bt_DobleClick.TabIndex = 0;
            this.bt_DobleClick.Text = "Boton";
            this.bt_DobleClick.UseVisualStyleBackColor = true;
            this.bt_DobleClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DobleClick);
            this.bt_DobleClick.MouseEnter += new System.EventHandler(this.CambioColor);
            this.bt_DobleClick.MouseLeave += new System.EventHandler(this.ColorOriginal);
            // 
            // BotonDobleClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_DobleClick);
            this.Name = "BotonDobleClick";
            this.Size = new System.Drawing.Size(119, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_DobleClick;
    }
}
