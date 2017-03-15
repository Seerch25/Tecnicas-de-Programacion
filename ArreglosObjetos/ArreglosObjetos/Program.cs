using System;

namespace ArreglosObjetos
{
    class Program
    {
        static void Main()
        {

            Alumnos[] alumno2017 = new Alumnos[5];


            alumno2017[0] = new Alumnos();
            alumno2017[0].nombre = "Pepito";
            alumno2017[0].calificacion = 10;

            alumno2017[1] = new Alumnos();
            alumno2017[1].nombre = "Maria";
            alumno2017[1].calificacion = 9;

            for( int i=2; i < 5; i++ )
            {
                alumno2017[i] = new Alumnos();
                Console.WriteLine(" Ingresa el nombre del alumno {0}", i);
                alumno2017[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la calificación :");
                alumno2017[i].calificacion = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingresa la estatura :");
                alumno2017[i].estatura = Convert.ToSingle(Console.ReadLine());
            }


            Console.WriteLine("Nombres de los alumnos ");

        /*    for( int i=0; i < 5; i ++)
            {
              Console.WriteLine (alumno2017[i].nombre);
            }*/

            foreach( Alumnos alumnos in alumno2017  )
            {
                Console.WriteLine("El nombre del alumno es: {0} ", alumnos.nombre);
                Console.WriteLine("La calificación del alumno es : {0} y estatura : {1}", alumnos.calificacion, alumnos.estatura);
            }


        }
    }
}
