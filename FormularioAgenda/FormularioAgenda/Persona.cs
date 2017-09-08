using System;

namespace FormularioAgenda
{
    class Persona
    {

        /*Arreglos
         * int  [ ] arreglo = new int[10];
         * arreglo[0]= 5;
         * arreglo[1] = 2;
         *    for( int i=0; i < 10 ; i++)
         *    {
         *        Console.WriteLine( arreglo[i]  );
         *    } 
         * 
         *    string telefono = 12135454845233;
         *    
         *    for(int i=0; i < telefono.Length ; i ++)
         *    {
         *          Console.WriteLine(telefono[i]);
         *    
         *    }
         * 
         * 
         * 
         */


        private string nombre;
        private byte edad;
        private string telefono;
        private string correo;

        public byte Edad
        {
            get
            {
                return edad;
            }

            set
            {

                if( value >= 10  && value <= 95    )
                {
                    edad = value;
                }
                else
                {
                    edad = 15;
                }
            }
        }

        public Persona(string nombre, byte edad, string telefono, string correo )
        {
            this.nombre = nombre;
            Edad = edad;
            this.telefono = telefono;
            this.correo = correo;
        }

    }
}
