using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");

            int min = int.MinValue;
            int max = int.MaxValue;

            int n = 0;
            
            for (int i = 1; i < n; i++)
            {
                for (int g = 1; g < n; g++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number >= max)
                    {
                        max = number;
                    }
                    if (number <= min)
                    {
                        min = number;
                    }

                    Console.WriteLine("Max number "+ max);
                    Console.WriteLine("Min number " + min);
                }
            }
        }
    }
}

