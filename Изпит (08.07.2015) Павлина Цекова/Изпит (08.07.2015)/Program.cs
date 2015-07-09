using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Изпит__08._07._2015_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 2 to 9");
             int n = int.Parse(Console.ReadLine());
             if (n < 2  || n > 9 )
             {
                 Console.WriteLine(false);
             }
             int[] ourArray1 = new int[n*n];  
            int[,] ourArray = new int[n,n];
             for (int i = 0; i < ourArray.GetLength(0) ; i++)
             {
                 for (int g = 0; g < ourArray.GetLength(1); g++)
                 {
                     ourArray[i, g] = int.Parse(Console.ReadLine());

                 }
             }
             Console.WriteLine(  );
            int a = 0 ;
             for (int i = 0; i < ourArray.GetLength(0); i++)
             {
                 for (int g = 0; g < ourArray.GetLength(1); g++)
                 {
                     ourArray1[a++] = ourArray[g,i];
                  
                }
             } 
             int b = 0;
             for (int i = 0; i < ourArray1.Length; i++)
             {
                 b = b + ourArray1[i];
                 Console.WriteLine(ourArray1[i]);
             }
             Console.WriteLine("The sum is "+b);
        }
    }
}

  