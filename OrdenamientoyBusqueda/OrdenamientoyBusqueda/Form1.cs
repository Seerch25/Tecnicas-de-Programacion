using System;
using System.Drawing;
using System.Windows.Forms;
using OrdenamientoBusqueda;

namespace OrdenamientoyBusqueda
{
    public partial class Form1 : Form
    {
        int[] matriz;
        Ordenamiento ordena;
        Busqueda busca;

        int indice;

        public int Indice
        {
            get
            {
                return indice;
            }
            set
            {
                if( value > 9)
                {
                    indice = 9;
                }
                else
                {
                    indice = value;
                }
            }

        }


        public Form1()
        {
            matriz = new int[10];
            ordena = new Ordenamiento();
            busca = new Busqueda();
            InitializeComponent();
        }

        private void txt_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    matriz[Indice++] = Convert.ToInt16(txt_entrada.Text);
                    if (Indice == 9)
                    {
                        string mat = "";
                        for (int i = 0; i < 10; i++)
                        {
                            mat = mat + " " + matriz[i];
                        }

                        lb_secoriginal.Text = lb_secoriginal.Text + ":" + mat;
                    }
                    txt_entrada.Text = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Introduce un número entero");
                }

            }
            if (e.KeyChar == 26 && rdb_ordenar.Checked)
            {
                ordena.Burbuja(matriz);
                string mat = "";
                for (int i = 0; i < 10; i++)
                {
                    mat = mat + " " + matriz[i];
                }
                lb_secordenada.Text = lb_secordenada.Text + ":" + mat;
            }

            if (e.KeyChar == 25 && rdb_buscar.Checked)
            {
                try
                {
                    int dato = int.Parse(txt_entrada.Text);
                    dato = busca.Simple(matriz,dato);

                    if (dato != -1)
                    {
                        lb_elembusqueda.Text = lb_elembusqueda.Text + ": " + dato;
                    }
                    else
                    {
                        lb_elembusqueda.Text = lb_elembusqueda.Text + ": " + "Dato no encontrado";
                    }


                }
                catch(FormatException)
                {
                    MessageBox.Show("Ingresa un dato correcto");
                }


            }
            
            
            
        }

    }
 }

