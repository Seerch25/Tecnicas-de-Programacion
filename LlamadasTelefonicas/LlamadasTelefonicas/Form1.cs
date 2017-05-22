using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LlamadasTelefonicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            dgv_datos.Rows.Add(txt_nombre.Text, txt_telefono.Text,"0");
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            Tiempo.Start();           
        }

        int i = 0;
        private void btn_colgar_Click(object sender, EventArgs e)
        {
            
            Tiempo.Stop();
            dgv_datos.Rows[i++].Cells[2].Value = Segundos;
        }

        int Segundos;
        int minutos=1;
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if( Segundos > 59   )
            {
                Segundos = 0;
                lb_tiempo.Text = "Tiempo: " + minutos + ":" + Segundos;
            }

            lb_tiempo.Text = "Tiempo: " + Segundos++ + "s";

            if( minutos  == 30)
            {
                Tiempo.Stop();
                MessageBox.Show("El saldo de tu amigo se ha agotado, te recomendamos realizar otra recarga ");

            }
           
        }
    }
}
