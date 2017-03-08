using System;

namespace Excepciones2
{
    class TrajeIronman
    {
        private int botonpulsera;

        public int Botonpulsera
        {
            get
            {
                return botonpulsera;
            }
            set
            {
                if( value < 0)
                {
                    botonpulsera = -value;
                }
                else
                {
                    botonpulsera = value;
                }

            }
        }


        public void Volar()
        {
            switch(botonpulsera)
            {
                case 1:
                    Console.WriteLine("Activado");
                    break;
                case 2:
                    Console.WriteLine("Desactivado");
                    break;
                default:
                    Console.WriteLine("Orden no enviada");
                    break;
            }

        }
    }
}
