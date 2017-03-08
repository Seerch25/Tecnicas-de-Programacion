using System;

namespace EjercicioExtra
{
    class OperadoresArreglo : Arreglos
    {
        public OperadoresArreglo()
        {
            Console.WriteLine("Constructor operadores");
        }


        public static OperadoresArreglo operator +(OperadoresArreglo arr1, OperadoresArreglo arr2)
        {
            int[] sumarr = new int[arr1.Longitud];
            for (int i = 0; i < arr1.Longitud; i++ )
            {
                sumarr[i] = arr1.arreglo[i] + arr2.arreglo[i];
            }

            OperadoresArreglo arreglosuma = new OperadoresArreglo();
            arreglosuma.arreglo = sumarr;
            return arreglosuma;

        }

    }
}
