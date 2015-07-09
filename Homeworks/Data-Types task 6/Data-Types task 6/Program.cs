using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int a = int.Parse(Console.ReadLine());
            
            int result = (a / 2);
            Console.WriteLine(result);
        }
    }
}
