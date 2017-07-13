using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static string FrontBack(string str)
        {
            int len = str.Length;
            return str[len - 1] + str.Substring(1, len - 2) + str[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose your string.");
            string s1 = Console.ReadLine();
            
            string s2 = FrontBack(s1);
            
            Console.WriteLine("Here you go: " + s2);
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();          

        }
    }
}
