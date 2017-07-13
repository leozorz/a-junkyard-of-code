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

            string firstString = "w3resource";

            // string secString = "Python";

            string finalString = firstString.Substring(firstString.Length - 1) +firstString.Substring(1, firstString.Length - 2) + firstString.Substring(0, 1);

            Console.Write(finalString + "\n");

            Console.ReadKey();

        }
    }
}
