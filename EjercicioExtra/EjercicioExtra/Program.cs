using System;

namespace EjercicioExtra
{
    class Program
    {
        static void Main()
        {
            //Arreglo definido en Program
       /*     int[] arreglo = { 2, 5, -1, 10, 7 };
            Arreglos miArreglo = new Arreglos(arreglo);
            Arreglos miArreglo2 = new Arreglos();
            Console.WriteLine("  Primer arreglo: " + miArreglo.ToString() );
            Console.WriteLine(" Segundo arreglo:  " + miArreglo2);
            */
            OperadoresArreglo opera1 = new OperadoresArreglo();
            OperadoresArreglo opera2 = new OperadoresArreglo();            
            Console.WriteLine(opera1 + opera2);            
        }
    }
}
