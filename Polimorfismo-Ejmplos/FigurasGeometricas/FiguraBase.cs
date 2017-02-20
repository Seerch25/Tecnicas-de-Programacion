using System;

namespace FigurasGeometricas
{
    class FiguraBase
    {
        //Atributos de la clase Padre
        private float llado;
        private float radio;
        private sbyte nlados;
        private float altura;

        //Propiedades de la clase
        public float Llado
        {
            get
            {
                return llado;
            }
            set
            {
                if(value < 0)
                {
                    llado = -value;
                }
                else
                {
                    llado = value;
                }
            }
        }

        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value < 0)
                {
                    altura = -value;
                }
                else
                {
                    altura= value;
                }
            }
        }

        public float Radio
        {
            get
            {
                return radio;
            }
            set
            {
                if (value < 0)
                {
                    radio = -value;
                }
                else
                {
                    radio = value;
                }
            }
        }

        public sbyte Nlados
        {
            get
            {
                return nlados;
            }
            set
            {
                if (value < 0)
                {
                    nlados = Convert.ToSByte(-value);
                }
                else
                {
                    nlados = value;
                }
            }
        }

        public virtual float Perimetro(float longlados, sbyte nlados)
        {
            Nlados = nlados;
          //  this.nlados = nlados; Esto es válido pero no se encapsula.
            Llado = longlados;
            return Nlados * Llado;

        }

        public virtual float Area(float longlados  )
        {
            Llado = longlados;
            return Llado * Llado;
        }
    }




}
