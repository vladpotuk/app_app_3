using System;

public static class StringExtensions
{
    public static int LengthOfLastWord(this string input)
    {
        
        string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        
        if (words.Length == 0)
            return 0;

       
        return words[words.Length - 1].Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        string[] testStrings = { "This is a test string.", "Hello, world!", "   Trim   the   spaces.   ", "NoLastWord" };

        foreach (string str in testStrings)
        {
            Console.WriteLine($"The length of the last word in \"{str}\" is: {str.LengthOfLastWord()}");
        }
    }
}

