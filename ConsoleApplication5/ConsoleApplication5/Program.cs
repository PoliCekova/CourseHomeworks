using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4,5 };
            bool isSymetric = true;


            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isSymetric = false;
                    break;
                }

            }
             Console.WriteLine("The array is symetric:" + isSymetric);

                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
