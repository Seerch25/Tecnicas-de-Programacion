namespace OrdenamientoyBusqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.rdb_ordenar = new System.Windows.Forms.RadioButton();
            this.rdb_buscar = new System.Windows.Forms.RadioButton();
            this.lb_secoriginal = new System.Windows.Forms.Label();
            this.lb_secordenada = new System.Windows.Forms.Label();
            this.lb_elembusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Arreglo";
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(124, 34);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(84, 20);
            this.txt_entrada.TabIndex = 1;
            this.txt_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entrada_KeyPress);
            // 
            // rdb_ordenar
            // 
            this.rdb_ordenar.AutoSize = true;
            this.rdb_ordenar.Location = new System.Drawing.Point(251, 41);
            this.rdb_ordenar.Name = "rdb_ordenar";
            this.rdb_ordenar.Size = new System.Drawing.Size(63, 17);
            this.rdb_ordenar.TabIndex = 2;
            this.rdb_ordenar.TabStop = true;
            this.rdb_ordenar.Text = "Ordenar";
            this.rdb_ordenar.UseVisualStyleBackColor = true;
            // 
            // rdb_buscar
            // 
            this.rdb_buscar.AutoSize = true;
            this.rdb_buscar.Location = new System.Drawing.Point(251, 73);
            this.rdb_buscar.Name = "rdb_buscar";
            this.rdb_buscar.Size = new System.Drawing.Size(58, 17);
            this.rdb_buscar.TabIndex = 2;
            this.rdb_buscar.TabStop = true;
            this.rdb_buscar.Text = "Buscar";
            this.rdb_buscar.UseVisualStyleBackColor = true;
            // 
            // lb_secoriginal
            // 
            this.lb_secoriginal.AutoSize = true;
            this.lb_secoriginal.Location = new System.Drawing.Point(30, 79);
            this.lb_secoriginal.Name = "lb_secoriginal";
            this.lb_secoriginal.Size = new System.Drawing.Size(94, 13);
            this.lb_secoriginal.TabIndex = 0;
            this.lb_secoriginal.Text = "Secuencia original";
            // 
            // lb_secordenada
            // 
            this.lb_secordenada.AutoSize = true;
            this.lb_secordenada.Location = new System.Drawing.Point(30, 111);
            this.lb_secordenada.Name = "lb_secordenada";
            this.lb_secordenada.Size = new System.Drawing.Size(106, 13);
            this.lb_secordenada.TabIndex = 0;
            this.lb_secordenada.Text = "Secuencia ordenada";
            // 
            // lb_elembusqueda
            // 
            this.lb_elembusqueda.AutoSize = true;
            this.lb_elembusqueda.Location = new System.Drawing.Point(30, 148);
            this.lb_elembusqueda.Name = "lb_elembusqueda";
            this.lb_elembusqueda.Size = new System.Drawing.Size(116, 13);
            this.lb_elembusqueda.TabIndex = 0;
            this.lb_elembusqueda.Text = "Elemento de búsqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 211);
            this.Controls.Add(this.rdb_buscar);
            this.Controls.Add(this.rdb_ordenar);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.lb_elembusqueda);
            this.Controls.Add(this.lb_secordenada);
            this.Controls.Add(this.lb_secoriginal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.RadioButton rdb_ordenar;
        private System.Windows.Forms.RadioButton rdb_buscar;
        private System.Windows.Forms.Label lb_secoriginal;
        private System.Windows.Forms.Label lb_secordenada;
        private System.Windows.Forms.Label lb_elembusqueda;
    }
}

