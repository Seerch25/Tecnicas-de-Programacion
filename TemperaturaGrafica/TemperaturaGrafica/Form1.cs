using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace TemperaturaGrafica
{
    public partial class Form1 : Form
    {
        private SerialPort miPuerto;
        public Form1()
        {
            InitializeComponent();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            cmb_puertos.Items.AddRange(puertos);
            configurarToolStripMenuItem.Enabled = false;

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                miPuerto = new SerialPort();
                miPuerto.BaudRate = 9600;
                miPuerto.PortName = cmb_puertos.SelectedItem.ToString();
                miPuerto.Open();
                iniciarToolStripMenuItem.Enabled = false;       

            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);

            }
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaArduino pruebaArduino = new PruebaArduino(miPuerto);
            pruebaArduino.Show();

        }
    }
}
