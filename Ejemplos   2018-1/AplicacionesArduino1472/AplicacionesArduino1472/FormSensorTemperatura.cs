using System;
using System.ComponentModel.Design ;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace AplicacionesArduino1472
{
    public partial class FormSensorTemperatura : Form
    {
        private SerialPort miPuerto;
        private int temperatura;
        private int tiempotemp;

        public FormSensorTemperatura(SerialPort miPuerto)
        {
            this.miPuerto = miPuerto;
            InitializeComponent();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            temperatura = miPuerto.ReadByte();
            cht_graficar.Series["SerieTemperatura"].Points.AddXY(tiempotemp, temperatura);
            if( tiempotemp == 20)
            {
                tiempo.Stop();                
            }

        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cht_graficar.Titles.Add("Temperatura enviada por el LM35");
            tiempo.Start();
        }
    }
}
