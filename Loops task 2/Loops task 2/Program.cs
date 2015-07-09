using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                if (i % a == 1 && i % b == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
