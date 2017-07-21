using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string\n");
            string ab = Console.ReadLine();

            Console.WriteLine(ab.ToLower());

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();

        }
    }
}
