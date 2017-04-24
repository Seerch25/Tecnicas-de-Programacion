using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasColas
{
    public partial class Form1 : Form
    {
        Stack<string> PILA;

        public Form1()
        {

            InitializeComponent();
            PILA = new Stack<string>();

        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            PILA.Push(txt_pila.Text);
            lst_push.Items.Add(txt_pila.Text);
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
           
            if( PILA.Count != 0  )
            {
                lst_pop.Items.Add(PILA.Pop());
            }
            
            
           
        }
    }
}
