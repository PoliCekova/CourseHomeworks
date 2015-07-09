using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 3)
            {
                int result = a * 5;
                Console.WriteLine(result);
            }
            else if (a >= 4 && a <= 6)
            {
                int result2 = a * 10;
                Console.WriteLine(result2);
            }
            else if (a >= 7 && a <= 9)
            {
                int result3 = a * 50;
                Console.WriteLine(result3);
            }
        }
    }
}

