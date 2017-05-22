namespace TemperaturaGrafica
{
    partial class PruebaArduino
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
            this.ptb_led = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_led)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_led
            // 
            this.ptb_led.Image = global::TemperaturaGrafica.Properties.Resources.foco;
            this.ptb_led.Location = new System.Drawing.Point(80, 37);
            this.ptb_led.Name = "ptb_led";
            this.ptb_led.Size = new System.Drawing.Size(124, 116);
            this.ptb_led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_led.TabIndex = 0;
            this.ptb_led.TabStop = false;
            this.ptb_led.Click += new System.EventHandler(this.ptb_led_Click);
            // 
            // PruebaArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 207);
            this.Controls.Add(this.ptb_led);
            this.Name = "PruebaArduino";
            this.Text = "PruebaArduino";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_led)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_led;
    }
}