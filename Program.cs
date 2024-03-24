using System;

public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        
        string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
  
        return words.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        string[] testStrings = { "This is a test string.", "Hello, world!", "   Trim   the   spaces.   " };

        foreach (string str in testStrings)
        {
            Console.WriteLine($"The number of words in \"{str}\" is: {str.WordCount()}");
        }
    }
}
