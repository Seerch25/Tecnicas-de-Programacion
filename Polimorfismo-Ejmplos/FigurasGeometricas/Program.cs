using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main()
        {
            Triangulo miObjetoTriangulo = new Triangulo();
            Console.WriteLine("Introduce la base del triangulo: ");
            float baseTriangulo = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triangulo: ");
            float altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El área del triangulo es: {0}", miObjetoTriangulo.Area(baseTriangulo, altura));
        }
    }
}
