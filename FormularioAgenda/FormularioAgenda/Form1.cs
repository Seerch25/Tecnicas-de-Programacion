using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

                 for( int i =0; i < txtTelefono.Text.Length; i++)
                {
                    MessageBox.Show(txtTelefono.Text[i].ToString());
                }




                Persona persona = new Persona(txtNombre.Text, byte.Parse(txtEdad.Text), txtTelefono.Text, txtCorreo.Text);



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
    }
}
