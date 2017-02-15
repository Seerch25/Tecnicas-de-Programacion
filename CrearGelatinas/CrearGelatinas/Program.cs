using System;

namespace CrearGelatinas
{
    class Program
    {
        static void Main()
        {
            Gelatina miGelatina = new Gelatina();
            Console.WriteLine("Ingresar la temperatura de refrigeracion");
            float temperatura = float.Parse( Console.ReadLine());
            Gelatina suGelatina = new Gelatina(temperatura);

            Imposible miGelatinaImposible = new Imposible();
            Console.ReadLine();

        }
    }

    class Gelatina
    {
        private string marca;
        private const int agua = 1;
        private float temperatura;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public float Temperatura
        {
            get
            {
                return temperatura;
            }

            set
            {
                if (value > 100)
                    value = 95;
                else
                    temperatura = value;
            }
        }

        public void Mezclar()
        {
            Console.WriteLine("Mezclando agua con gelatina");
        }

        public void Hervir()
        {
            Console.WriteLine("El agua está a temperatura de ebullición");
        }

        public void Refrigerar()
        {
            Console.WriteLine("La gelatina estará preparada en unas horas");
        }
        public void Refrigerar(float temperatura)
        { 
            //Izquierdo es la propiedad
            //Lado derecho es el argumento del método Refrigerar
            Temperatura = temperatura;
            Console.WriteLine("Refrigerando a temperatura {0}",Temperatura);
        }

        public Gelatina()
        {
            Marca = "Pronto";
            Temperatura = 3F;
            Mezclar();
            Hervir();
            Refrigerar();
            Console.WriteLine(" Tu gelatina de la marca {0} está lista y a temperatura {1}", Marca, Temperatura);
        }

        public Gelatina(float temperatura)
        {
            Mezclar();
            Hervir();
            Temperatura = 3F;
            Refrigerar(temperatura);
        }

    }

    class Imposible:Gelatina
    {
        private string fruta;

        public string Fruta
        {
            get
            {
                return fruta;
            }

            set
            {
                fruta = value;
            }
        }

        public void PicarFruta()
        {
            Console.WriteLine("Fruta picada");
        }
        public void AgregarFruta()
        {
            Console.WriteLine("Agregar Fruta"); 
        }
        public Imposible()
        {
            Mezclar();
            Hervir();
            Refrigerar();
            PicarFruta();
            AgregarFruta();
            Console.WriteLine("Su Gelatina imposible está Lista a Temparatura {0}",Temperatura);

        }

    }

}
