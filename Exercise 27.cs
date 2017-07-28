using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input  a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10;
                n = n/10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);


            Console.ReadKey();
        }


    }
}
