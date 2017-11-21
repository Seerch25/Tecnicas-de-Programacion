using System;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace AplicacionesArduino1472
{
    public partial class Form1 : Form
    {
        private SerialPort miPuerto;

        public Form1()
        {
            InitializeComponent();
            conectarToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;

        }

        public void selecciona()
        {
            toolStrip_cmbPuertos.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            toolStrip_cmbPuertos.Items.AddRange(puertos);
        }


        private void sensorTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSensorTemperatura formSensorTemperatura = new FormSensorTemperatura(miPuerto);
            formSensorTemperatura.MdiParent=this;
            formSensorTemperatura.Show();
        }

        

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selecciona();
            conectarToolStripMenuItem.Enabled = true;
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                miPuerto = new SerialPort();
                miPuerto.BaudRate = 9600;
                miPuerto.PortName = toolStrip_cmbPuertos.SelectedItem.ToString();
                miPuerto.Parity = Parity.None;
                miPuerto.DataBits = 8;
                miPuerto.Open();
                desconectarToolStripMenuItem.Enabled = true;
                conectarToolStripMenuItem.Enabled = false;
            }
            catch(IOException error )
            {
                MessageBox.Show("Error:" + error.Message);
            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(miPuerto.IsOpen  )
            {
                try
                {
                    conectarToolStripMenuItem.Enabled = true;
                    miPuerto.Close();
                }
                catch( IOException error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }

        }
    }
}
