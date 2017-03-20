using System;

namespace Interfaces
{
    class Estufa: Electrodomesticos,IEncender
    {
        private byte boton;

        byte IEncender.Boton
        {
            get
            {
                return boton;
            }
            set
            {
                if( value < 0 || value > 10)
                {
                    boton = 1;
                }
                else
                {
                    boton = value;
                }
            }
        }
        void IEncender.Encender()
        {
            Console.WriteLine("Encendiendo estufa en el nivel: {0}", boton);
            
        }

        public Estufa()
        {
            Marca = " GL ";
            DarSaludo();
            Console.WriteLine("Marca Estufa: {0}", Marca);
        }

    }
}
