using System;
using System.Collections;

namespace Colecciones
{
    class Program
    {
        static void Main()
        {
            // Colecciones
            ArrayList miColeccion = new ArrayList();
            miColeccion.Add("Uno");
            miColeccion.Add(2);
            miColeccion.Add(true);
            miColeccion.Add(2.25F);
            miColeccion.Add('C');

            Console.WriteLine(miColeccion[0]);
            for(int i=1; i < miColeccion.Count; i ++)
            {
                Console.WriteLine(miColeccion[i]);
            }

            //Coleccion de facturas

            ArrayList coleccionFacturas = new ArrayList();

            Facturas miFactura;


            //Primera operación fundamental de una colección
            //Código para escribir o agregar un nuevo elemento a
            //la colección.

            for(int i = 0; i < 2; i++)
            {
                //Es necesario invocar el constructor de la clase
                //Facturas para poder agregar nuevos elementos.
                miFactura = new Facturas();
                Console.WriteLine("Introduce el id de la factura {0}:", i);
                miFactura.id = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Introduzca el nombre:");
                miFactura.nombre = Console.ReadLine();
                Console.WriteLine("Introduzca el RFC: ");
                miFactura.rfc = Console.ReadLine();
                coleccionFacturas.Add(miFactura);
            }
            
           
            //Para extraer los elementos de la colección es necesario
            //indicar el tipo de dato con el que vamos a trabajar.
            //En nuestro caso podemos reutilizar el objeto miFactura
            //para poder acceder a cada elemento, lo que implica
            //realizar un casteo
    
            //Segunda operación fundamental realizada con una colección
            
           
            //Recorriendo los elementos de la colección
            for(int i=0; i < coleccionFacturas.Count; i++)
            {
                //Casteo de la colección para acceder a cada elemento;
                miFactura= (Facturas)coleccionFacturas[i];
                Console.WriteLine("ID: {0} Nombre: {1}  RFC: {2}",miFactura.id, miFactura.nombre, miFactura.rfc);
            }

            //Tercera operación fundamental de una colección
            //Eliminar un elemento en la colección implica
            //utilizar el método RemoveAt indicando el índice que deseamos eliminar
            coleccionFacturas.RemoveAt(1);

            //Comprobación: si introdujo 3 elementos en la sección anterior
            //en esta sección deberían desplegarse solamente 2 elementos
            //Recorriendo los elementos de la colección
            Console.WriteLine("Imprimiendo dos elementos");
            for (int i = 0; i < coleccionFacturas.Count; i++)
            {
                //Casteo de la colección para acceder a cada elemento;
                miFactura = (Facturas)coleccionFacturas[i];
                Console.WriteLine("ID: {0} Nombre: {1}  RFC: {2}", miFactura.id, miFactura.nombre, miFactura.rfc);
            }


        }
    }
}
