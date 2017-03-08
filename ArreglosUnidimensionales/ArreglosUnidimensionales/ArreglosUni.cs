using System;

namespace ArreglosUnidimensionales
{
    class ArreglosUni
    {
        //Atributo  tipo arreglo unidimensional
        //los corchetes indican que consta
        // de un sólo índice para acceder a los
        //elementos que lo componen
        // Todo Arreglo es objeto de una clase 
        // por lo tanto podemos acceder a sus propiedades

        private int[] arreglo;

        /// <summary>
        ///Constructor para asignar
        ///valores al arreglo
        /// </summary>
        /// <param name="arreglo">Arreglo de tipo entero</param>
        public ArreglosUni(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public ArreglosUni()
        {
            int N;
            int[] arreglo;
            Console.WriteLine("Ingresa la longitud del arreglo");
            N = int.Parse(Console.ReadLine());
            // Inicializando el arreglo
            arreglo = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Ingresa el valor de Arreglo[{0}] = ", i);
                arreglo[i] = Convert.ToInt16(Console.ReadLine());
                //Agregando salto de línea
                Console.WriteLine();
            }

            this.arreglo = arreglo;

        }


        public void Imprime()
        {
            // La propiedad Length nos permite obtener
            //la longitud del arreglo unidimensional
            for(int i = 0; i  < arreglo.Length; i++  )
            {
                Console.WriteLine("Arreglo[{0}] = {1} ", i, arreglo[i]);
            }
        }

        public static ArreglosUni operator+(ArreglosUni a1, ArreglosUni a2  )
        {
                int[] aux = new int[a1.arreglo.Length];

                for (int i = 0; i < a1.arreglo.Length; i++)
                {
                    aux[i] = a1.arreglo[i] + a2.arreglo[i];
                }
                ArreglosUni ar;
                ar = a1;
                ar.arreglo = aux;
            
            
            return ar;
        }


        public override string ToString()
        {
            String arregloimp = "";
            for( int i = 0; i < arreglo.Length; i++)
            {
                arregloimp = arregloimp + " " + arreglo[i];
                
            }
            return arregloimp;

        }
    }
}
