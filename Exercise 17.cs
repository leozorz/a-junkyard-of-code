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
            
            string firstString = Console.ReadLine();

            string s2 = firstString.Substring(0, 1) + firstString + firstString.Substring(0, 1);

            Console.Write(s2 + "\n");

            Console.ReadKey();



        }
    }
}
