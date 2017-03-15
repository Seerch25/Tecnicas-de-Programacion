using System;

namespace Multidimensionales
{
    class Program
    {
        static void Main()
        {
            int[,] arreglo2D = new int[2, 2];

            arreglo2D[0, 0] = 12;
            arreglo2D[0, 1] = 15;
            

            //Primer For recorre renglones
            for(int i=0; i< 2; i++ )
            {
                //Segundo For recorre las columnas
                for(int j=0;j< 2; j++)
                {
                    Console.WriteLine("Ingrese el elemento A[{0},{1}]=", i, j);
                    arreglo2D[i, j] = Convert.ToInt16(Console.ReadLine());

                }

            }


            //Primer For recorre renglones
            for (int i = 0; i < 2; i++)
            {
                //Segundo For recorre las columnas
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" " + arreglo2D[i,j]);   

                }
                Console.WriteLine();
            }

            int[,] segundoarr2D = { {1,2,3}, {4,5,6 }};
            //Primer For recorre renglones
            for (int i = 0; i < 2; i++)
            {
                //Segundo For recorre las columnas
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + segundoarr2D[i, j]);

                }
                Console.WriteLine();
            }


            int[,,] matriz3D = { { {2,3,4}, {5,6,7} }, { {1,4,5 },{8,9,10}} };




        }
    }
}
