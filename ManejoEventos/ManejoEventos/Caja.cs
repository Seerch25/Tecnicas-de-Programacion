using System;

namespace ManejoEventos
{
    class Caja
    {
        //Firma del delegado es: void Cambio()
        public delegate void Cambio();
        //Definiendo que hay un evento
        // con la firma es: Cambio
        //Y el evento es: Propiedad
        //Es decir, disparar el evento Cambio cuando
        // se escriba en alguna propiedad.
        public event Cambio Propiedad;


        //Atributos
        private string color;
        private int largo;
        private int ancho;
        private int altura;


        //Propiedades
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                //Relacionando el evento
                //con el delegado para
                //definir el manejador del evento
                Cambio evento = Propiedad;
                if(evento != null  )
                {
                    //Manejador del evento
                    evento();
                }

                color = value;
            }
        } 

    }
}
