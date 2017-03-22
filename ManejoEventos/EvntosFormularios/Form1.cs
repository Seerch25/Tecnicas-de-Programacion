using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvntosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_datos.Text); 
        }

        private void txt_datos_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se cambió el texto");
        }
    }
}
