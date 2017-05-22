using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TemperaturaGraficar
{
    public partial class Valores : Form
    {
        StreamWriter sw=null;

        public Valores()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {                             

                sw = new StreamWriter("archivo.txt");

                foreach(string linea  in rtb_datos.Lines )
                {
                    sw.WriteLine(linea);
                }
                

            }
            catch(IOException E)
            {
                MessageBox.Show("error" + E.Message);
            }
            finally
            {
                sw.Close();
            }

        }
    }
}
