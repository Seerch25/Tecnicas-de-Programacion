namespace TemperaturaGraficar
{
    partial class Valores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_datos = new System.Windows.Forms.RichTextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_datos
            // 
            this.rtb_datos.Location = new System.Drawing.Point(45, 29);
            this.rtb_datos.Name = "rtb_datos";
            this.rtb_datos.Size = new System.Drawing.Size(369, 347);
            this.rtb_datos.TabIndex = 0;
            this.rtb_datos.Text = "X\tY";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(449, 43);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Valores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 444);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.rtb_datos);
            this.Name = "Valores";
            this.Text = "Valores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_datos;
        private System.Windows.Forms.Button btn_guardar;
    }
}