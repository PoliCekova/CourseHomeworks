using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ourArray2 = new int[] { 9, 1, 3, 4, 6 };

            int[] ourArray1 = new int[] { 4, 6, 2, 8, 1 };
            for (int i = 0; i < ourArray1.Length; i++)
            {
                for (int j = 0; j < ourArray2.Length; j++)
                {
                    if (ourArray1[i] == ourArray2[j])
                    {
                        Console.WriteLine(ourArray2[j]);
                        break;

                    }
                }
            }
        }
    }
}
