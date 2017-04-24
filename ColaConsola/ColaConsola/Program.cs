using System;
using System.Collections.Generic;
namespace ColaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nombres = new Queue<string>();

            nombres.Enqueue("Armando");
            nombres.Enqueue("Luis");
            for(int i=0; i <= nombres.Count; i++)
                 Console.WriteLine(nombres.Dequeue());

        }
    }
}
