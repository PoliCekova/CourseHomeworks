using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {

                {3,4,5,7 },
                {2,6,8,1},
                {7,9,5,3,},
                {5,9,1,0}

            };

            for (int i = 0; i < matrix.GetLength (0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    Console.Write(" "+ matrix[i,g]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    Console.Write(" " + matrix[i, g]);
                }
                Console.WriteLine();

                for (int i = 0; i < matrix.GetLength(0); i++) 
                {
                    for (int g = 0; g < matrix.GetLength(1); g++)
                    {
                        
                    }
                }
            }
        }
    }
}
