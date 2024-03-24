using System;

public static class StringExtensions
{
    public static int CountVowels(this string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiouyAEIOUY".Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text1 = "Hello World";
        string text2 = "This is a test string";

        Console.WriteLine($"Number of vowels in '{text1}': {text1.CountVowels()}"); 
        Console.WriteLine($"Number of vowels in '{text2}': {text2.CountVowels()}"); 
    }
}

