using System;

namespace Excepciones2
{
    class Program
    {
        static void Main()
        {
            try
            {
                byte boton;
                TrajeIronman miTraje = new TrajeIronman();
                Console.WriteLine(" Introduce un número correspondiente a la pulsera ");
                boton = Convert.ToByte(Console.ReadLine());
                miTraje.Botonpulsera = boton;
                miTraje.Volar();
                Console.ReadLine();
            }

            catch (FormatException  e )
            {
                Console.WriteLine("Error, excepción controlada : " + e.Message);
            }
            catch( OverflowException e)
            {
                Console.WriteLine("Error, La orden debe ser entre 1 y 2: " + e.Message);
            }

            



        }
    }
}
