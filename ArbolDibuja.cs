using System.Drawing;
using System.Windows.Forms;
namespace Arboles
{

    public class Arbol
    {
        private nodo raiz = null;
        PictureBox ptb;
        Bitmap b;
        Graphics g;
        Pen lapiz;
        int despX=150;
        int despY=50;
        int raizX;
        int raizY;

        public nodo Raiz
        {
            get
            {
                return raiz;
            }
        }

        public Arbol() {

        }

        public Arbol(PictureBox ptb)
        {
            this.ptb = ptb;
            lapiz = new Pen(Color.Purple, 5);
            b = new Bitmap(ptb.Width, ptb.Height);
            raizX = ptb.Width / 2;
            raizY = 20;
        
        }



        public void inserta_nodo(nodo A, nodo padre, int valor, int rama)
        {
            ptb.Image = (Image)b;
            g = Graphics.FromImage(b);
            if (A == null)
            {
                A = new nodo();
                A.dato = valor;
                A.izq = null;
                A.der = null;
                if (raiz == null)
                {
                    raiz = A;
                    g.DrawString(A.dato.ToString(), new Font("Comic Sans", 15, FontStyle.Bold), new SolidBrush(Color.Black), raizX, raizY);
                    A.posx = raizX;
                    A.posy = raizY;
                    g.DrawEllipse(new Pen(Color.Black, 1), A.posx-5, A.posy, 30, 30);
                }
                else
                {
                    if (rama == 1)
                    {                        
                        A.posx =padre.posx-despX;
                        A.posy =padre.posy+despY;
                        padre.izq = A;
                        g.DrawString(A.dato.ToString(), new Font("Comic Sans", 15, FontStyle.Bold), new SolidBrush(Color.Black),A.posx , A.posy);
                        g.DrawEllipse(new Pen(Color.Black, 1), A.posx - 5, A.posy, 30, 30);
                        g.DrawLine(new Pen(Color.Black, 2), padre.posx, padre.posy, A.posx, A.posy);
                    }

                    else if (rama == 2)
                    {
                        A.posx = padre.posx + despX;
                        A.posy = padre.posy + despY;
                        padre.der = A;
                        g.DrawString(A.dato.ToString(), new Font("Comic Sans", 15, FontStyle.Bold), new SolidBrush(Color.Black), A.posx, A.posy);
                        g.DrawEllipse(new Pen(Color.Black, 1), A.posx + 5, A.posy, 30, 30);
                        g.DrawLine(new Pen(Color.Black, 1), padre.posx, padre.posy, A.posx, A.posy);
                    }
                    if(despX >=60)
                    {
                        despX -= 20;
                    }
                    
                }

            }
            else
            {
                if (valor < A.dato)
                {


                    inserta_nodo(A.izq, A, valor, 1);
                }
                else if (valor > A.dato)
                {

                    inserta_nodo(A.der, A, valor, 2);
                }
                else
                {
                    MessageBox.Show("Dato duplicado ");
                }
            }
        }

        public void preorden(nodo A)
        {
            MessageBox.Show(A.dato.ToString(), "Mostrando ");
            preorden(A.izq);
            preorden(A.der);
        }


        public void inorden(nodo A)
        {

            if (A != null)
            {

                inorden(A.izq);
                MessageBox.Show(A.dato.ToString(), "Mostrando Dato");
                inorden(A.der);

            }
        }
        public void posorden(nodo A)
        {

            if (A != null)
            {
                posorden(A.izq);
                posorden(A.der);
                MessageBox.Show(A.dato.ToString(), "Mostrando Dato");

            }
        }



    }

    public class nodo
    {
        public int dato;
        public nodo izq;
        public nodo der;
        public int posx;
        public int posy;
    }
    
}
