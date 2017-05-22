namespace TemperaturaGraficar
{
    partial class PruebaConexion
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
            this.ptb_foco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foco)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_foco
            // 
            this.ptb_foco.Image = global::TemperaturaGraficar.Properties.Resources.bulb;
            this.ptb_foco.Location = new System.Drawing.Point(59, 12);
            this.ptb_foco.Name = "ptb_foco";
            this.ptb_foco.Size = new System.Drawing.Size(99, 96);
            this.ptb_foco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_foco.TabIndex = 0;
            this.ptb_foco.TabStop = false;
            this.ptb_foco.Click += new System.EventHandler(this.ptb_foco_Click);
            // 
            // PruebaConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 149);
            this.Controls.Add(this.ptb_foco);
            this.Name = "PruebaConexion";
            this.Text = "PruebaConexion";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_foco;
    }
}