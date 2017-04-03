
namespace Listas
{
    public class Lista<T>
    {
        public nodo<T> A;
        public nodo<T> A2;

        public void Inserta(T Dato)
        {
            nodo<T> P = new nodo<T>();
            P.dato = Dato;
            P.siguiente = A;
            A = P;
            A2 = A;
        }

        public T Reccorre()
        {
            T Dato;

            if( A !=null)
            {
                Dato = A.dato;
                A = A.siguiente;
            }
            else
            {
                A = A2;
                Dato = default(T);
            }
            return Dato;

        }

        public void eliminaDato(T Dato)
        {
            nodo<T> Q;
            nodo<T> S;



        }


    }

   public class nodo<T>
    {
        public nodo<T> siguiente;
        public T dato;
    }
}
