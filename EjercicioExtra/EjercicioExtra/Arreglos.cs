using System;

namespace EjercicioExtra
{
    class Arreglos
    {
        //Definiendo atributos
        public int[] arreglo;
        private int longitud;

        //Encapsulando el atributo longitud
        public int Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                if( value < 0  ||  value > 10  )
                {
                    longitud = 10;
                }
                else
                {
                    longitud = value;
                }
            }

        }


        public Arreglos()
        {

            bool Error = false; 

            do
            {
                Error = false;
                try
                {
                    Console.WriteLine("Ingresa la longitud del arreglo unidimensional");
                    Longitud = Convert.ToInt16(Console.ReadLine());
                    arreglo = new int[Longitud];

                    for (int i = 0; i < Longitud; i++)
                    {
                        Console.Write("Ingresa el valor Arreglo[{0}]=", i);
                        arreglo[i] = Convert.ToInt16(Console.ReadLine());
                        // Console.WriteLine();
                    }
                }
                catch (FormatException error)
                {
                    Error = true;
                    Console.WriteLine("Error de Formato: " + error.Message);
                }
                catch (OverflowException error)
                {
                    Error = true;
                    Console.WriteLine("Error de número: " + error.Message);
                }
                catch (IndexOutOfRangeException error)
                {
                    Error = true;
                    Console.WriteLine("Error de índice" + error.Message);
                }
                
                //
                //while (!Error); while (Error != true) ;  Niega la condición
            } while ( Error);//while (Error ==  true);
        }

        //Segundo constructor
        public Arreglos(int [] arreglo )
        {
            this.arreglo = arreglo;
        }


        public override string ToString()
        {
            string aux="";
            // Si solamente existe una instrucción dentro de
            //de un bucle, no es necesario utilizar las llaves
            /*for (int i = 0; i < arreglo.Length; i++)                
                aux = aux  + " " + arreglo[i].ToString();*/
            // for (int i = 0; i < arreglo.Length; i++)  aux = aux + " " + arreglo[i].ToString();
            for (int i = 0; i < arreglo.Length; i++)
            {
                aux = aux + " " + arreglo[i].ToString();
            }
                

            return aux ;
        }

    }
}
