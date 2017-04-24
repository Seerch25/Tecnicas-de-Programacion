namespace PilasColas
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
            this.lst_push = new System.Windows.Forms.ListBox();
            this.lst_pop = new System.Windows.Forms.ListBox();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.txt_pila = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_push
            // 
            this.lst_push.FormattingEnabled = true;
            this.lst_push.Location = new System.Drawing.Point(179, 32);
            this.lst_push.Name = "lst_push";
            this.lst_push.Size = new System.Drawing.Size(170, 147);
            this.lst_push.TabIndex = 0;
            // 
            // lst_pop
            // 
            this.lst_pop.FormattingEnabled = true;
            this.lst_pop.Location = new System.Drawing.Point(422, 32);
            this.lst_pop.Name = "lst_pop";
            this.lst_pop.Size = new System.Drawing.Size(170, 147);
            this.lst_pop.TabIndex = 0;
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(56, 70);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(75, 38);
            this.btn_push.TabIndex = 1;
            this.btn_push.Text = "PUSH";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(56, 141);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(75, 38);
            this.btn_pop.TabIndex = 1;
            this.btn_pop.Text = "POP";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // txt_pila
            // 
            this.txt_pila.Location = new System.Drawing.Point(56, 32);
            this.txt_pila.Name = "txt_pila";
            this.txt_pila.Size = new System.Drawing.Size(100, 20);
            this.txt_pila.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.txt_pila);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.lst_pop);
            this.Controls.Add(this.lst_push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_push;
        private System.Windows.Forms.ListBox lst_pop;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.TextBox txt_pila;
    }
}

