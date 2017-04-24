using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EjemploPila
{
    public partial class Form1 : Form
    {
        Stack<string> PILA;

        public Form1()
        {
            PILA = new Stack<string>();
            InitializeComponent();
        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            PILA.Push(txt_nombres.Text);
            lst_push.Items.Add(txt_nombres.Text);
        }

        private void tbn_pop_Click(object sender, EventArgs e)
        {
            if (PILA.Count == 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                string aux = PILA.Pop();
                lst_pop.Items.Add(aux);
                lst_push.Items.Remove(aux);
            }
        }
    }
}
