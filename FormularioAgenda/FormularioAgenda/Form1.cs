using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioAgenda
{
    public partial class Form1 : Form
    {
        private Persona[,] persona;
        private byte indice;
        private byte indicegrupo;
        private byte numpersonas;

        public byte Indice
        {
            get
            {
                return indice;
            }
            set
            {
                if( value > numpersonas-1)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            }
        }

        public byte Indicegrupo { get => indicegrupo; set => indicegrupo = value; }

        public Form1()
        {
            numpersonas = 2;
            persona = new Persona[numpersonas,2];
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Excepción: Son errores en tiempo de ejecución generalmente
            //provocados por el uso incorrecto del programa.

            //Clase Exception: 
            try
            {
                if (txtNombre.Text == "")
                {
                    string error = "Debes ingresar tu nombre";
                    throw new ApplicationException(error);
                }
                if (txtTelefono.Text == "")
                {
                    string error = "Debes ingresar tu teléfono";
                    throw new ApplicationException(error);
                }
                if (txtCorreo.Text == "")
                {
                    string error = "Debes ingresar tu correo";
                    throw new ApplicationException(error);
                }
                if(rdBgrupo1.Checked==true)
                {
                    persona[Indice++, 0] = new Persona(txtNombre.Text, byte.Parse(txtEdad.Text), txtTelefono.Text, txtCorreo.Text);
                }
                if(rdBgrupo2.Checked)
                {
                    persona[Indice++, 1] = new Persona(txtNombre.Text, byte.Parse(txtEdad.Text), txtTelefono.Text, txtCorreo.Text);
                }
                
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";

                MessageBox.Show("Datos Ingresados");
            }
            catch (FormatException error)
            {

                MessageBox.Show(error.Message, " Error del dato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }


            catch
            {
                MessageBox.Show(" Hubo un error en el código  ");
            }                    
        }

        

        

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rdBgrupo1.Checked)
                {
                    txtNombre.Text = persona[Indice, 0].Nombre;
                    txtEdad.Text = persona[Indice, 0].Edad.ToString();
                    txtTelefono.Text = persona[Indice, 0].Telefono;
                    txtCorreo.Text = persona[Indice, 0].Correo;
                    Indice++;
                }
                if (rdBgrupo2.Checked)
                {
                    txtNombre.Text = persona[Indice, 1].Nombre;
                    txtEdad.Text = persona[Indice, 1].Edad.ToString();
                    txtTelefono.Text = persona[Indice, 1].Telefono;
                    txtCorreo.Text = persona[Indice, 1].Correo;
                    Indice++;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No hay datos que mostrar");
            }


        }
    }
}
