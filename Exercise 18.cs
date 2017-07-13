using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first integer");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer");

            int b = Convert.ToInt32(Console.ReadLine());
            
            
            if((a < 0 && b > 0) || (a>0 && b<0))
                {
                Console.WriteLine("True");
            }

            else Console.Write("False\n");

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
