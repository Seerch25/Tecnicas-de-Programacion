using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace TemperaturaGrafica
{
    public partial class PruebaArduino : Form
    {
        private SerialPort Puertoprueba;
        bool enciendeApaga=false;
        public PruebaArduino(SerialPort Puertoprueba)
        {
            InitializeComponent();
            this.Puertoprueba = Puertoprueba;
        }

        private void ptb_led_Click(object sender, EventArgs e)
        {
            if(enciendeApaga)
            {
                Puertoprueba.Write("a");
                ptb_led.BackColor = Color.Yellow;
                enciendeApaga = false;
            }
            else
            {
                Puertoprueba.Write("b");
                ptb_led.BackColor = Color.White;
                enciendeApaga = true;
            }

        }
    }
}
