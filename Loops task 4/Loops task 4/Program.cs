using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int factorialA = 1;
            int factorialB = 1;

            int sum = a - b;

            for (int i = 1; i < a; i++)
            {
                factorialA *= i;
            }
            for (int g = 1; g < b; g++)
            {
                factorialB *= j; 
                
            }
            Console.WriteLine(factorialA * factorialB / sum);

        }
    }
}
