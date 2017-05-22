using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace TemperaturaGraficar
{
    public partial class PruebaConexion : Form
    {
        SerialPort puerto;
        bool estado_led=false; 

        public PruebaConexion(SerialPort port  )
        {
            InitializeComponent();
            ptb_foco.BackColor = Color.White;
            this.puerto = port;
        }

        private void ptb_foco_Click(object sender, EventArgs e)
        {
            if(estado_led )
            {
                ptb_foco.BackColor = Color.Yellow;
                puerto.Write("a");
                estado_led = false;
            }
            else
            {
                ptb_foco.BackColor = Color.White;
                puerto.Write("b");
                estado_led = true;
            }

        }
    }
}
