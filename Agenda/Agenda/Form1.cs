using System;
using System.Drawing;
using Datosagenda;
using Listas;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Lista<Datosamigo> datos = new Lista<Datosamigo>();
        Datosamigo amigo;
        /*
        protected int indice;

        public int Indice
        {
            get
            {
                return indice;
            }
            set
            {
                if( value < 0 || value > 19)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            }
        }

        protected Datosamigo [] CompañerosClase;
        */
        public Form1()
        {
          //  CompañerosClase = new Datosamigo[20];
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            amigo.nombre = txt_nombre.Text;
            amigo.correo = txt_correo.Text;
            amigo.direccion = txt_direccion.Text;

            datos.Inserta(amigo);
            
            /*
            CompañerosClase[Indice].nombre = txt_nombre.Text;
            CompañerosClase[Indice].correo = txt_correo.Text;
            CompañerosClase[Indice].telefono = new string[3];
            CompañerosClase[Indice].telefono[0] = txt_telefono.Text;
            CompañerosClase[Indice].direccion = txt_direccion.Text;
            Indice++;

            txt_nombre.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            MessageBox.Show("Datos ingresados de forma correcta");
            */
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            amigo = datos.Reccorre();

            txt_nombre.Text = amigo.nombre;
            txt_correo.Text = amigo.correo;
            txt_direccion.Text = amigo.direccion;

            /*
            txt_nombre.Text = CompañerosClase[Indice].nombre;
            txt_correo.Text = CompañerosClase[Indice].correo;
            CompañerosClase[Indice].telefono = new string[3];
            txt_telefono.Text = CompañerosClase[Indice].telefono[0];
            txt_direccion.Text = CompañerosClase[Indice].direccion;
            Indice++;
           */
        }
    }
}
