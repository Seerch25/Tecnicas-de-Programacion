using System;
using System.ComponentModel.Design;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionesArduino0513
{
    public partial class Temperatura : Form
    {
        SaveFileDialog saveFileDialog;
        StreamWriter sw;
        public Temperatura()
        {
            InitializeComponent();
        }

        int contador = 10;
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            sw.WriteLine(" " + contador + "      " + contador * 10);
            contador++;

            if (contador == 100)
            {
                Tiempo.Stop();
                sw.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog = new SaveFileDialog();
                if( saveFileDialog.ShowDialog()== DialogResult.OK  )
                {
                    sw = new StreamWriter(saveFileDialog.FileName);
                }
            }
            catch(IOException error)
            {
                MessageBox.Show("Error" + error.Message);
            }

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiempo.Start();
        }
    }
}
