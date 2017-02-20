using System;

namespace Polimorfismo_Ejmplos
{
    class Metodos
    {


        /* 
         * Este es el caso en que se necesita constructor
        public Metodos()
        {

            //float perimetro = FuncionPerimetroCuadrado(5.2F);
            Console.WriteLine("El perímetro de un cuadrado es: {0} ", FuncionPerimetroCuadrado(5.2F));
            Subrutina();
            Procedimiento(4, 5);

        }
        */

            //Static nos permit manipular métodos o atributos sin 
            //la necesidad de declarar un constructor.

        public static void Subrutina()
        {
            int var1 = 20;
            int var2 = 30;
            Console.WriteLine(" La suma de {0} + {1} es: {2} ", var1, var2, var1 + var2);

        }

        /// <summary>
        /// Este método es un ejemplo de procedimiento
        /// donde es necesario definir los argumentos.
        /// </summary>
        /// <param name="var1">Es una variable de tipo entera a sumar</param>
        /// <param name="var2">Es una variable de tipo entera a sumar</param>

        public static void Procedimiento( int var1, int var2 )
        {
            Console.WriteLine("La suma de {0} + {1} es: {2}", var1, var2, var1 + var2);
        }

        /// <summary>
        /// El presente método calcula el perímetro de un cuadrado
        /// </summary>
        /// <param name="lado"> Representa al longitud del lado de un cuadrado</param>
        /// <returns></returns>

        public float FuncionPerimetroCuadrado(float lado )
        {
            return lado * 4;
        }

        

    }
}
