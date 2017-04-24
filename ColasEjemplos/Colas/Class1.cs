using System.Windows.Forms;
namespace Colas
{
    /// <summary>
    /// Maneja a una cola como arreglo
    /// </summary>

    public class ColaArr<T>
    {

        private int MAX;
        private int FRENTE;
        private int FINAL;

        private T []  Cola;

        /// <summary>
        /// Establece el número máximo de elementos dentro de la COLA
        /// </summary>
        /// <param name="MAX"></param>
        public ColaArr(int MAX)
        {
            this.MAX = MAX;
            Cola = new T[this.MAX];
        }

        /// <summary>
        /// Insertar elemento a la cola.
        /// La cola está limitada al número máximo de elementos especificados
        /// en el constructor
        /// </summary>
        /// <param name="Dato">Dato de tipo T</param>
        public void insertar(T Dato)
        {
            if(FINAL < MAX)
            {
                Cola[FINAL++] = Dato;
            }
            else
            {
                MessageBox.Show("Cola llena");
            }

        }

        /// <summary>
        /// Devuelve el tipo de dato especificado en la instancia
        /// </summary>
        /// <returns>T</returns>
        public T Eliminar()
        {
            T Dato;
            if( FRENTE != FINAL )
            {
                Dato =Cola[FRENTE];
                Cola[FRENTE++] = default(T);
            }
            else
            {                
                
                Dato = default(T);
                MessageBox.Show("Cola Vacía");
            }

            return Dato;

        }

    }
}
