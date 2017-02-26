using System;

namespace SobreCargaOperadores
{
    class Program
    {
        static void Main()
        {
            float sumando1;
            float sumando2;
            float real;
            float imaginaria;

            Console.WriteLine("Ingresa el primer sumando");
            sumando1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo sumando");
            sumando2 = Convert.ToSingle(Console.ReadLine());
            Operaciones.suma(sumando1, sumando2);
            Operaciones.multiplica(sumando1, sumando2);




            Console.WriteLine("Ingresa la parte real del número complejo 1 ");
            real = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa la parte imaginaria del número complejo 1 ");
            imaginaria = Convert.ToSingle(Console.ReadLine());
            Complejo c1 = new Complejo(real, imaginaria);

            Console.WriteLine("Ingresa la parte real del número complejo 2 ");
            real = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa la parte imaginaria del número complejo 2 ");
            imaginaria = Convert.ToSingle(Console.ReadLine());
            Complejo c2 = new Complejo(real, imaginaria);

            Complejo c3 = c1 + c2;

            Console.WriteLine("La suma de {0} y {1} es: {2} ", c1.ToString(), c2.ToString(), c3.ToString());



            //Es para esperar la visualización de los datos
            //Para que no se cierre la aplicación después
            //de ejecutarla. Espera un Enter 
            Console.ReadLine();


        }
    }
}
