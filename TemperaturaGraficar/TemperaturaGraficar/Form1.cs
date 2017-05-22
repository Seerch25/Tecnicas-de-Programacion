using System;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace TemperaturaGraficar
{
    public partial class Form1 : Form
    {
        private SerialPort miPuerto;
        private int temperatura;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void smenu_escribirValores_Click(object sender, EventArgs e)
        {
            Valores formvalores = new Valores();
            formvalores.Show();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            cmb_ports.Items.AddRange(puertos);
            iniciarToolStripMenuItem.Enabled = true;           
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                miPuerto = new SerialPort();
                miPuerto.BaudRate = 9600;
                miPuerto.PortName = cmb_ports.SelectedItem.ToString();
                miPuerto.Open();
                pruebaToolStripMenuItem.Enabled = true;
                iniciarToolStripMenuItem.Enabled = false;
                configurarToolStripMenuItem.Enabled = false;

            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaConexion pruebac = new PruebaConexion(miPuerto);
            pruebac.Show();
        }

        private void txt_lectura_Click(object sender, EventArgs e)
        {
            tiempo_lectura.Start();
        }

        private void tiempo_lectura_Tick(object sender, EventArgs e)
        {
            temperatura = miPuerto.ReadByte();
            cht_temperatura.Series["serie_temp"].Points.AddXY(i++, temperatura);
            if (i == 500)
            {
                tiempo_lectura.Stop();
                miPuerto.Close();
                iniciarToolStripMenuItem.Enabled = true;
                configurarToolStripMenuItem.Enabled = true;
            }

        }
    }
}
