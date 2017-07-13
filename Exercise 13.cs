using System;
public class Exercise13
{
    public static void Main()
    {
        int x;
         
        Console.Write("Enter a number: ");
        x=Convert.ToInt32(Console.ReadLine());
     
        Console.WriteLine("{0}{0}{0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0}{0}{0}",x);
    }
}
