using System;
public class Exercise24
{
    public static void Main()
    {
        //  Console.WriteLine("Find the biggest word in the line:\n");

        //        string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";

        //Console.WriteLine(line + "\n");

        Console.WriteLine("Choose your string.");
        string line = Console.ReadLine();

        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        string word = "";

        int control = 0;

        foreach (String s in words)
        {
            if (s.Length > control)
            {
                word = s;
                control = s.Length;
            }
        }

        Console.WriteLine(word);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
