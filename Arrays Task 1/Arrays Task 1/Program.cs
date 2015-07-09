using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ourArray = new int[n];
            Console.WriteLine("Please enter values ot the array");

            for (int i = 0; i < n; i++)
            {
                ourArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in ourArray)
            {
                if (i % 2 == 0)
                {
                    int Result = 0;
                    Result += i;
                }
                Console.WriteLine("Resul is" + "Result");
            }
        }
    }
}
