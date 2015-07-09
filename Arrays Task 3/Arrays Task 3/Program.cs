using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ourArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter number");
                ourArray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Index" + (i * 10)); 
            }
        }
    }
}
