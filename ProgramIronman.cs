using System;

namespace Excepciones2
{
    class Program
    {
        static void Main()
        {
            try
            {
                int boton;
                TrajeIronman miTraje = new TrajeIronman();
                Console.WriteLine(" Introduce un número correspondiente a la pulsera ");
                boton = Convert.ToInt16(Console.ReadLine());
                miTraje.Botonpulsera = boton;
                miTraje.Volar();
                Console.ReadLine();
            }
            catch(FormatException  e )
            {
                Console.WriteLine("Error, excepción controlada : " + e.Message);
            }

        }
    }
}
