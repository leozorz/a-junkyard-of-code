using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    class Program
    {
        private static string source;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the celsius degrees' value:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahr = ((celsius * 9) / 5) + 32;

            double kelvin = celsius + 273.15;

            Console.WriteLine("The value in fahrenheit is {0}, and the value in kelvin is {1}", fahr, kelvin);

            Console.WriteLine("Press any key...");
            Console.ReadLine();

        }

    }


}


