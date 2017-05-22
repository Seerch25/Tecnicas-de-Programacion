using System;

namespace CalculandoPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el grado para establecer error");
            int f = int.Parse(Console.ReadLine());
            Program.CalculoPI(f);
            Console.ReadLine();
        }

        static void CalculoPI(int m)
        {
            int n = 4;
            
            double d = Math.Sqrt(2);
            double pi = n * d / 2;
            double error = Math.Pow(10, -m);
            Console.WriteLine(" n     |  Longitud Lado | Pi    | Diferencia ");
            while(true)
            {
                double p1 = pi;
                n = 2 * n;
                double auxiliar1 = Math.Sqrt(1 - d *d/ 4);
                d = Math.Sqrt(2 - 2 * auxiliar1);
                pi = n * d / 2;
                double diferencia = Math.Abs(p1 - pi);
                if( Math.Abs(  p1 - pi) < error  )
                {
                    break;
                }
                Console.WriteLine(" {0}     |  {1}         | {2}    | {3}     ", n,d,pi,diferencia);
            }
        }
    }
}
