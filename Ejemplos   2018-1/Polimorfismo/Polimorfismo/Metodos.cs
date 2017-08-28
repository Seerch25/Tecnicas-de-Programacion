using System;

namespace Polimorfismo
{
    class Metodos
    {
        //Metodo se puede clasificar en tres paradigmas:
        //Subrutinas: Es una acción que no requiere de entradas y salidas.
        //Procedimientos: Es una acción que requiere de una o más entradas pero no tiene salidas.
        //Funciones: Es una acción que requiere de entradas para devolver una salida.


        private int n;

        private int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 1)
                {
                    n = 1;
                }
                else if (value >= 12)
                {
                    n = 12;
                }
                else
                {
                    n = value;
                }
            }
        }
        public void factorial()
        {
            int factor=1;
            Console.WriteLine("Ingresa el valor del número a calcular factorial");
            N = Int16.Parse(Console.ReadLine());
            Console.WriteLine("  Calculando el factorial de: {0}",N);
            for( int i=1; i<= N; i++)
            {
                factor = factor * i;
            }

            Console.WriteLine("Imprimiendo el factorial: {0}", factor);
        }

        public void factorial( int N, string nombre )
        {
            int factor = 1;
            this.N = N;
            for ( int i = 1; i <= this.N; i++)
            {
                factor *= i; //factor = factor * i;
            }

            Console.WriteLine("Hola {0} el factorial de tu número es :{1}",nombre,factor);
        }

        public int factorial(int N)
        {
            this.N = N;
            if( this.N == 1 || this.N == 0)
            {
                return 1;
            }
            else
            {
                return this.N*factorial(this.N - 1);
            }

        }


    }
}
