using System;
public class Exercise24
{
    public static void Main()
    {

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
