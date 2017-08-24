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
            // First read in the number of doubles the user intends to enter.
            Console.Write("Enter the number of values to average: ");
     
            int num = Convert.ToInt32(Console.ReadLine());
           
            // Now declare an array of that size.

            double[] doublesArray = new double[num]; // Here’s the ‘N’.
                                                             // Accumulate the values into an array.
            for (int i = 0; i < num; i++)
            {
                // Prompt the user for another double.

                Console.Write("enter double #" + (i + 1) + ": ");
                string val = Console.ReadLine();
                double value = Convert.ToDouble(val);
                // Add this to the array using bracket notation.
                doublesArray[i] = value;
            }
            // Accumulate ‘numElements’ values from
            // the array in the variable sum.
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum = sum + doublesArray[i];
            }
            // Now calculate the average.
            double average = sum / num;
            // Output the results in an attractive format.
            Console.WriteLine();
            Console.Write(average + " is the average of(");
            for (int i = 0; i < num; i++)
            {
                Console.Write (+doublesArray[i] + "; ");
            }
            Console.WriteLine(") / " +num);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
