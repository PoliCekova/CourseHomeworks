using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = int.MinValue;
            int min = int.MaxValue;

            int[,] ourArray1 = new int[,] 
            {
                {34,54,77,56},
                {65,23,51,98},
                {5,3,61,77,},
            };
            for (int i = 0; i <ourArray1.GetLength(0) ; i++)            
            {
                for (int g = 0; g < ourArray1.GetLength(1); g++)
                {
                    if (ourArray1[i, g] > max)
                    {
                        max = ourArray1[i, g];

                    }
   
                    if (ourArray1[i,g] < min)
                    {
                        min = ourArray1[i, g];
                    }
                    
                }
               
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
