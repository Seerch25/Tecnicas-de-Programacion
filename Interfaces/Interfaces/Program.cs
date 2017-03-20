using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            IEncender iencenderestufa = new Estufa();
            Console.WriteLine("Introduzca el nivel de encendido de la estufa");
            iencenderestufa.Boton = byte.Parse(Console.ReadLine());
            iencenderestufa.Encender();

        }
    }
}
