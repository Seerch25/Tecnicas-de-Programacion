using System;
using System.ComponentModel;
using System.Drawing;
using Colas;
using System.Windows.Forms;

namespace ColasEjemplos
{
    public partial class Form1 : Form
    {
        ColaArr<string> cola;
        int indice;

        public Form1()
        {
            cola = new ColaArr<string>(10);
            

            InitializeComponent();
        }

        private void txt_dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if( indice < 10  )
                {
                    cola.insertar(txt_dato.Text);
                    lst_insertar.Items.Add(txt_dato.Text);
                    txt_dato.Text = "";
                    indice++;
                }                    
                
          
            }
            else if (e.KeyChar == 26)
            {
                string aux = cola.Eliminar();
                if( aux != null)
                {
                    lst_eliminado.Items.Add(aux);
                    lst_insertar.Items.Remove(aux);
                }              
                
            }
        }
    }
}
