using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndex = 0;
            int maxIndex = 0;


            int[] ourArray = new int[] { 2, 54, 31, 7, 62, 9, 4, 30, 33, 53 };
            for (int i = 0; i < ourArray.Length; i++)
            {
                if (ourArray[i] > max && i % 2 == 0 )
                {
                    max = ourArray[i];
                    maxIndex = i;

                }
                if (ourArray[i] < min && i % 2 == 1 )
                {
                    min = ourArray[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("min number is " +min+ " and its index is "+minIndex);
            Console.WriteLine(" max number is " +max+ " and its index is " +   maxIndex);
        }
    }
}       
            
            
            //       {
 //           for (int i = 10; i <= 999; i++)
 //           {
 //               bool isSymmetric = false;
 //               isSymmetric = Symmetric(i);
 //           }
 //       }
    
 //   private static bool Symmetric(int number);
  
 //   {

 //    }
 //           if (number < 100 && number % 11 == 0 )
 //           {
 //               Console.WriteLine(number);
 //           }

 //         if (number>= 100)
 //        { 
 //        int firstNumber =  number / 100;
 //        int lastNumber = number % 10;
 //       if (firstNumber == lastNumber)
 //       {
 //           Console.WriteLine(number);
 //       }
 //       }
 //   }
 //|}

