using System;

namespace FigurasGeometricas
{
    class Triangulo:FiguraBase
    {
        public override float Perimetro(float longlados, sbyte nlados)
        {
            return base.Perimetro(longlados, nlados);
        }

        public float Area(float basetriangulo ,float altura)
        {
            Llado = basetriangulo;
            Altura = altura;
            return Llado * Altura / 2;
        }
    }
}
