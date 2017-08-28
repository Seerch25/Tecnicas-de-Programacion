using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace AbrirAplicacionesExternas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ejecutaAplicacion = new OpenFileDialog();

            if (ejecutaAplicacion.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Process.Start(ejecutaAplicacion.FileName);

                }
                catch (Exception error)

                {
                    MessageBox.Show("Error:  " + error.Message);
                }
            }

        }
    }
}
