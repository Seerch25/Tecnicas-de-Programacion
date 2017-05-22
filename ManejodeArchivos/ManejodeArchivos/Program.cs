using System;
using System.IO;
namespace ManejodeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Program.EscribeArchivo();
            //Program.AgregaLineasArchivo();
            Program.LeerArchivo();
        }

        static void EscribeArchivo()
        {
            StreamWriter sw = null;
            string cadena;
            try
            {
                //Abriendo el flujo para escribir en el archivo
                sw = new StreamWriter("archivocadena.txt");
                Console.WriteLine("Escriba las líneas a almacenar \n. Finalice una línea pulsando al tecla <ENTER> \n Finalice y cierre el documento tecleando nuevamente <ENTER>");
                cadena = Console.ReadLine();
                while(cadena.Length != 0)
                {
                    //Escribe dentro del Archivo
                    sw.WriteLine(cadena);
                    cadena = Console.ReadLine();
                }

                Console.WriteLine("Documento completado, hasta pronto");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Cerramos el flujo, por buenas prácticas
                sw.Close();
            }

        }

        static void AgregaLineasArchivo()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string cadena;
            try
            {
                fs = new FileStream("archivocadena.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("Mismas indicaciones que en el programa anterior");
                cadena = Console.ReadLine();
                while(cadena.Length != 0  )
                {
                    sw.WriteLine(cadena);
                    cadena = Console.ReadLine();
                }

                Console.WriteLine("Tu texto se agregó correctamente");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Cerrando el flujo en el orden indicado
                sw.Close();
                fs.Close();
            }

        }

        static void LeerArchivo()
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("archivocadena.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string cadena;
                while( (cadena = sr.ReadLine()) != null  )
                {
                    Console.WriteLine(cadena);
                }

                Console.WriteLine("Archivo accedido correctamente");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

        }



    }
}
