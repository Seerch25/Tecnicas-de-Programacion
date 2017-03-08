using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MatricesMultidimensionales
{
    public partial class Form1 : Form
    {
        private int[,] matriz;
        private int n;
        private int m;

        public int N
        {
            get
            {
                return n;
            }

            set
            {
                if( value < 5 || value > 10 )
                {
                    n = 10;
                }
                else
                {
                    n = value;
                }
                
            }
        }

        public int M
        {
            get
            {
                return m;
            }

            set
            {
                if( m < 5 || m > 10)
                {
                    m = 10;
                }
                else
                {
                    m = value;
                }
                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt16( txt_renglones.Text);
                M = Convert.ToInt16(txt_renglones.Text);
                matriz = new int[N, M];
                dgv_matriz.RowCount = N;
                dgv_matriz.ColumnCount = M;


                for( int i = 0; i < N; i++ )
                {
                    for( int j=0; j < M; j++)
                    {
                        String instruccion = String.Format("Introduce el elemento m[{0},{1}]=", i, j);
                        matriz[i, j] = Convert.ToInt16(Interaction.InputBox(instruccion,"Datos de la matriz"));
                    }
                }

                

            }
            catch(FormatException error)
            {
                MessageBox.Show("Error en código" + error.Message);
            }
        }
    }
}
