using System;
using System.Collections.Generic;
using System.Drawing;
using EstructurasAgenda;
using System.Windows.Forms;

namespace AgendaLista
{
    public partial class Form1 : Form
    {
        Datos amigo;
        int indice;
        List<Datos> amigos;
        
        protected int Indice
        {
            get
            {
                return indice;
            }
            set
            {  
                if( value < 0 || value > amigos.Count -1 )
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }

            }
        }


        public Form1()
        {
            amigos = new List<Datos>();
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            amigo.nombre = txt_nombre.Text;
            amigo.telefono = txt_telefono.Text;
            amigo.correo = txt_correo.Text;
            amigo.direccion.calle = txt_Direccion.Text;

            amigos.Add(amigo);
            txt_nombre.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_Direccion.Text = "";
            MessageBox.Show("Dato ingresado");
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Indice++;
            txt_nombre.Text = amigos[Indice].nombre;
            txt_correo.Text = amigos[Indice].correo;
            txt_telefono.Text = amigos[Indice].telefono;
            txt_Direccion.Text = amigos[Indice].direccion.calle;
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            amigos.RemoveAt(Indice);
            MessageBox.Show("Elemento Eliminado");
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lst_telefonos.Items.Add(txt_telefono.Text);
            }
            else if (e.KeyChar == 12)
            {
                MessageBox.Show("Tecleaste la 12 ascii");
            }
        }
    }
}
