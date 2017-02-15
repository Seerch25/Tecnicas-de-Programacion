using System;

namespace Transportes
{
    class Automovil
    {
        private float precio;
        private string color;
        private string marca;
        private float velocidad;

        public float Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                if (value < 0)
                    velocidad = -value;
                else
                velocidad = value;
            }
        }
        public Automovil()
        {
            Velocidad = 1;
        }


        public float VelocidadAuto()
        {
            Velocidad++; //Velocidad = Velocidad +1;
            return Velocidad ;
        }

    }
}
