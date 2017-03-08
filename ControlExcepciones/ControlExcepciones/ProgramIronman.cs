using System;

namespace Excepciones2
{
    class Program
    {
        static void Main()
        {
            //La variable error_producido 
            //es de tipo local y por lo tanto
            //asignamos un valor inicial
            bool error_producido=false;
            do
            {
                error_producido = false;
                try
                {
                    //Variable local boton
                    //int boton;
                    sbyte boton;
                    //Instancia de la clase TrajeIronman
                    TrajeIronman miTraje = new TrajeIronman();
                    Console.WriteLine(" Introduce un número correspondiente a la pulsera ");
                    //Asignamos el ingreso de dato y realizamos la conversión
                    //boton = Convert.ToInt16(Console.ReadLine());
                    boton = Convert.ToSByte(Console.ReadLine());
                    miTraje.Botonpulsera = boton;
                    miTraje.Volar();

                    Console.ReadLine();
                }


                catch (FormatException e)
                {
                    Console.WriteLine("Error, excepción controlada : " + e.Message);
                    error_producido = true;
                }
                catch (OverflowException error)
                {
                    error_producido = true;
                    Console.WriteLine("Error, excepción de Overflow" + error.Message);
                }
                catch (Exception e)
                {
                    error_producido = true;
                    Console.WriteLine("Hubo un error: " + e.Message);
                }



            } while (error_producido == true);


            

        }
    }
}
