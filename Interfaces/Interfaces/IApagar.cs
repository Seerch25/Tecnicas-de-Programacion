using System;

namespace Interfaces
{
    public interface IApagar
    {                                //No se permite definir atributos o campos
        byte boton { get; set; }    // Propiedad definida            
        void Apagar();              //Este método está definido
                                    //Pero no tiene ninguna instrucción en 
                                    //su interior lo que implica que no 
                                    //está implementado
                                    
    }
}
