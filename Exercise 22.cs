using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write an integer\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a >= 80 && a <= 120) || (a >= 180 && a <= 220))
            {

                Console.WriteLine("True");
            }

            else Console.WriteLine("False");

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();

        }
    }
}
