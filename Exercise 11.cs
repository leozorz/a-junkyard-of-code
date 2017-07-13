using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildASentence
{
    class Program
    {
        private static string source;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than {0}", Math.Abs(a));

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();

        

        }

    }


}


