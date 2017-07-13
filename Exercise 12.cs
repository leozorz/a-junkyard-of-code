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
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

    }

}


