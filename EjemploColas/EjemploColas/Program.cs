using System;
using System.Collections.Generic;
using System.Threading;

namespace EjemploColas
{
    class Program
    {
        static void Main()
        {
            bool continuar=false;
            Queue<string> nombres = new Queue<string>();
            do
            {
                Console.WriteLine("Ingresa tu nombre a la lista de espera");
                nombres.Enqueue(Console.ReadLine());
                Console.WriteLine("¿Desea agregar a otra persona? (s/n) ");
                char contesta = Convert.ToChar( Console.ReadLine());
                if( contesta == 's')
                {
                    continuar = true;
                }
                else if(contesta == 'n')
                {
                    continuar = false;
                }
            } while ( continuar );


            // Permitimos la conversión implícita
            foreach (Object objetonombre in nombres)
            {
                Console.WriteLine("Persona fuera de la fila: {0} ", objetonombre);
                Thread.Sleep(500);
            }

            int elem_espera = nombres.Count;
            //En este código se eliminan los elementos de la estructura Queue nombre
            for(int i=0; i< elem_espera; i++ )
            {
                Console.WriteLine("Elementos: {0} ", nombres.Dequeue());
                Thread.Sleep(1000);
            }


            
                
            
        }
    }
}
