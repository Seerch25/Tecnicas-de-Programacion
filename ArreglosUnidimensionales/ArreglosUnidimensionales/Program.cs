using System;

namespace ArreglosUnidimensionales
{
    class Program
    {
        static void Main()
        {           
            ArreglosUni miArreglo = new ArreglosUni();
            Console.WriteLine(miArreglo.ToString());
            int[] arreglo2 = { 2,5,10,-1,-3,20  };
            ArreglosUni miArreglo2 = new ArreglosUni(arreglo2);
            Console.WriteLine( miArreglo2.ToString());
            ArreglosUni ar = miArreglo + miArreglo2;
            Console.WriteLine("La suma de los arreglos es: " + ar.ToString());

        }
    }
}
