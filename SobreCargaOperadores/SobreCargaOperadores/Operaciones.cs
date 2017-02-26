using System;
//GitHub
namespace SobreCargaOperadores
{
    public static class Operaciones
    {
        //Las clases estáticas no utilizan constructores
        /*
            public Operaciones()
            {

            }        
         */
         //Todos los elementos de una clase static
         // deberán ser también de tipo static
        private static float resultado;


     public static void suma(float operando1, float operando2)
        {
            resultado = operando1 + operando2;
            Console.WriteLine("La suma de {0} y {1} es: {2}", operando1, operando2, resultado);

        }

        public static void multiplica( float operando1, float operando2)
        {
            resultado = operando1 * operando2;
            string mostrar = resultado.ToString();

            Console.WriteLine("El resultado  de multiplicar {0} y {1} es: {2}", operando1, operando2, mostrar);

        }


    }
}
