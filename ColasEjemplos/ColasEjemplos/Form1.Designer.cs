namespace ColasEjemplos
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
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.lst_insertar = new System.Windows.Forms.ListBox();
            this.lst_eliminado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(42, 60);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(100, 20);
            this.txt_dato.TabIndex = 0;
            this.txt_dato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dato_KeyPress);
            // 
            // lst_insertar
            // 
            this.lst_insertar.FormattingEnabled = true;
            this.lst_insertar.Location = new System.Drawing.Point(181, 47);
            this.lst_insertar.Name = "lst_insertar";
            this.lst_insertar.Size = new System.Drawing.Size(120, 160);
            this.lst_insertar.TabIndex = 1;
            // 
            // lst_eliminado
            // 
            this.lst_eliminado.FormattingEnabled = true;
            this.lst_eliminado.Location = new System.Drawing.Point(361, 47);
            this.lst_eliminado.Name = "lst_eliminado";
            this.lst_eliminado.Size = new System.Drawing.Size(120, 160);
            this.lst_eliminado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.lst_eliminado);
            this.Controls.Add(this.lst_insertar);
            this.Controls.Add(this.txt_dato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.ListBox lst_insertar;
        private System.Windows.Forms.ListBox lst_eliminado;
    }
}

