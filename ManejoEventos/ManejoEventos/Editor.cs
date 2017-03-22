using System;

namespace ManejoEventos
{
    class Editor
    {

        public Caja miCaja;

        public Editor()
        {
            miCaja = new Caja();
            //Apuntar al Método que se va a ejecutar
            miCaja.Propiedad += MiCaja_Propiedad;
            Console.WriteLine("La caja es de color: {0}", miCaja.Color);
            miCaja.Color = "Rojo";
            Console.WriteLine("La caja es de color: {0}", miCaja.Color);



        }
        //El manejador del evento dentro de la clase Editor
        //Debe tener la misma firma del delegado
        //Clase que se suscribe

        private void  MiCaja_Propiedad()
        {
            Console.WriteLine("Cambio en la propiedad de la caja");
            
        }

    }
}
