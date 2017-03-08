using System;

namespace Excepciones
{
    class Program
    {
        static void Main()
        {
            Object o2 = null;

            try
            {
                int i2 = (int)o2;
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Intentando hacer un casteo de un valor nulo");
            }

            catch(InvalidCastException e)
            {
                Console.WriteLine("Error de casteo: " + e.Message);
            }
     
     
            
        }

     
    }
}
