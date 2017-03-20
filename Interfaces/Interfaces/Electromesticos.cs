using System;

namespace Interfaces
{
    abstract class Electrodomesticos
    {
        private string marca;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                if( value == "")
                {
                    marca = "Genérica";
                }
                else
                {
                    marca = value;
                }
                
            }
        }

        public void DarSaludo()
        {
            Console.WriteLine("***HOLA**** ");
        }
    }
}
