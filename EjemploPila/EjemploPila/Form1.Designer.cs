namespace EjemploPila
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
            this.btn_push = new System.Windows.Forms.Button();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lst_push = new System.Windows.Forms.ListBox();
            this.lst_pop = new System.Windows.Forms.ListBox();
            this.tbn_pop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(31, 74);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(75, 23);
            this.btn_push.TabIndex = 0;
            this.btn_push.Text = "PUSH";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(31, 28);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(100, 20);
            this.txt_nombres.TabIndex = 1;
            // 
            // lst_push
            // 
            this.lst_push.FormattingEnabled = true;
            this.lst_push.Location = new System.Drawing.Point(180, 28);
            this.lst_push.Name = "lst_push";
            this.lst_push.Size = new System.Drawing.Size(120, 147);
            this.lst_push.TabIndex = 2;
            // 
            // lst_pop
            // 
            this.lst_pop.FormattingEnabled = true;
            this.lst_pop.Location = new System.Drawing.Point(372, 28);
            this.lst_pop.Name = "lst_pop";
            this.lst_pop.Size = new System.Drawing.Size(120, 147);
            this.lst_pop.TabIndex = 2;
            // 
            // tbn_pop
            // 
            this.tbn_pop.Location = new System.Drawing.Point(31, 114);
            this.tbn_pop.Name = "tbn_pop";
            this.tbn_pop.Size = new System.Drawing.Size(75, 23);
            this.tbn_pop.TabIndex = 0;
            this.tbn_pop.Text = "POP";
            this.tbn_pop.UseVisualStyleBackColor = true;
            this.tbn_pop.Click += new System.EventHandler(this.tbn_pop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PILA VACÍA";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_pop);
            this.Controls.Add(this.lst_push);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.tbn_pop);
            this.Controls.Add(this.btn_push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.ListBox lst_push;
        private System.Windows.Forms.ListBox lst_pop;
        private System.Windows.Forms.Button tbn_pop;
        private System.Windows.Forms.Label label1;
    }
}

