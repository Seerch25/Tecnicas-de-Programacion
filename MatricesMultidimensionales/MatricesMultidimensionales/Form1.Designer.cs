namespace MatricesMultidimensionales
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
            this.dgv_matriz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_renglones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_columnas = new System.Windows.Forms.TextBox();
            this.btn_leer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_matriz
            // 
            this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matriz.Location = new System.Drawing.Point(12, 177);
            this.dgv_matriz.Name = "dgv_matriz";
            this.dgv_matriz.Size = new System.Drawing.Size(399, 180);
            this.dgv_matriz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Renglones";
            // 
            // txt_renglones
            // 
            this.txt_renglones.Location = new System.Drawing.Point(105, 48);
            this.txt_renglones.Name = "txt_renglones";
            this.txt_renglones.Size = new System.Drawing.Size(100, 20);
            this.txt_renglones.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            // 
            // txt_columnas
            // 
            this.txt_columnas.Location = new System.Drawing.Point(104, 84);
            this.txt_columnas.Name = "txt_columnas";
            this.txt_columnas.Size = new System.Drawing.Size(100, 20);
            this.txt_columnas.TabIndex = 2;
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(277, 45);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(75, 23);
            this.btn_leer.TabIndex = 3;
            this.btn_leer.Text = "Leer datos";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dimensiones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(277, 81);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 369);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.txt_columnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_renglones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_matriz);
            this.Name = "Form1";
            this.Text = "Matrices en dos dimensiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_matriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_renglones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_columnas;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

