using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {
            Metodos misMetodos = new Metodos();
            misMetodos.factorial();
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el valor a calcular factorial:  ");
            int N = Int16.Parse(Console.ReadLine());
            Console.Clear();
            misMetodos.factorial(N, nombre);
            Console.WriteLine("Usando una función tu factorial es: {0}", misMetodos.factorial(N));
            Console.ReadLine();

        }
    }
}
