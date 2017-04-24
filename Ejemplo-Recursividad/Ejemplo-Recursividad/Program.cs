using System;

namespace Ejemplo_Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" {0} ", Program.factorial(5));
        }

        public static int factorial(int N )
        {
            if (N == 0)
            {
                return 1;
            }                
            else
            {
                return N*factorial(N - 1);
            }

        }

    }
}
