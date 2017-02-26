using System;

namespace SobreCargaOperadores
{
    class Complejo
    {
        private float real;
        private float imaginario;

        //Constructor de la clase complejo
        public Complejo(float real, float imaginario)
        { 
            //this:  distingue a los atributos de los parámetros
            //o variables locales
            this.real = real;
            this.imaginario = imaginario;            
        }

        /// <summary>
        /// Sobrecargando el operador "+", el método
        /// es de tipo public, static y debe llevar la
        ///palabra reservada operator
        /// </summary>
        /// <param name="c1">Complejo 1 con parte real y parte imaginaria  </param>
        /// <param name="c2">Complejo 2 con parte real y parte imaginaria</param>
        /// 
        /// <returns></returns>
        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real + c2.real, c1.imaginario + c2.imaginario);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginario));
        }
    }
}
