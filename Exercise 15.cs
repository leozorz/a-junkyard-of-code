using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
    
       static void Main(string[] args)
        {

            Console.WriteLine("Choose your string.");
            string s1 = Console.ReadLine();

            for (;;)

            {

                if (String.IsNullOrEmpty(s1))

                {
                    Console.WriteLine("The string is empty, please enter a new string");
                    s1 = Console.ReadLine();
                }

                if (!String.IsNullOrEmpty(s1))
                {
                    break;

                }

            }


            Console.WriteLine("Choose which character you want to remove.");
            int index_char = Convert.ToInt32(Console.ReadLine());

            string s2 = s1.Remove(index_char-1, 1);

            Console.WriteLine("Here you go: " + s2);
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();

        }
    }
}
