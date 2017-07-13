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

            int c = Math.Abs(a - b);
            
            if(a>b)
            {
                int d = 2 * c;
                Console.WriteLine("The double of the difference is {0}",d);
            }

            else Console.Write("The absolute value of the difference is {0}\n",c);

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
