
namespace OrdenamientoBusqueda
{
    public class Ordenamiento
    {
        public void Burbuja(int [] matriz)
        {
            int AUX;
            for(int i=0; i < matriz.Length; i++ )
            {
                for(int j=0; j < matriz.Length-1; j++ )
                {
                    if(matriz[j] > matriz[j+1] )
                    {
                        AUX = matriz[j];
                        matriz[j] = matriz[j + 1];
                        matriz[j + 1] =AUX;
                    }

                }
            }
        }
    }

    public class Busqueda
    {
        /// <summary>
        /// Este método se encarga de buscar un elemento
        /// dentro de la matriz proporcionada y devuelve el
        /// su respectiva posición.
        /// </summary>
        /// <param name="matriz">Es un arreglo unidimensional</param>
        /// <param name="Dato">Es un elemento entero</param>
        public int Simple(int [] matriz, int Dato )
        {
            int indice=0;
            for (int i = 0; i < matriz.Length; i++)
            { 
                if( Dato == matriz[i]  )
                {
                    indice = i;
                }
                else
                {
                    indice = -1;
                }
            }
            return indice;
        }

    }


}
