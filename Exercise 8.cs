using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Please enter a number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} x 0 = {1}", a, a*0);
            Console.WriteLine("{0} x 1 = {1}", a, a*1);
            Console.WriteLine("{0} x 2 = {1}", a, a * 2);
            Console.WriteLine("{0} x 3 = {1}", a, a * 3);
            Console.WriteLine("{0} x 4 = {1}", a, a * 4);
            Console.WriteLine("{0} x 5 = {1}", a, a * 5);
            Console.WriteLine("{0} x 6 = {1}", a, a * 6);
            Console.WriteLine("{0} x 7 = {1}", a, a * 7);
            Console.WriteLine("{0} x 8 = {1}", a, a * 8);
            Console.WriteLine("{0} x 9 = {1}", a, a * 9);
            Console.WriteLine("{0} x 10 = {1}", a, a * 10);

            Console.WriteLine("Press any key...");
            Console.ReadLine();


        }
    }
}
