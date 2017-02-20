using System;

namespace Polimorfismo_Ejmplos
{
    class Program
    {
        static void Main()
        {
            Metodos miMetodo = new Metodos();
            Metodos.Procedimiento(7, 50);
            Metodos.Subrutina();

            Console.WriteLine("El perimetro de un cuadrado es: {0}", miMetodo.FuncionPerimetroCuadrado(5.2F));


            Console.ReadLine();


        }
    }
}
