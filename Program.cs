using System;


public static class StringExtensions
{
    public static int CountSentences(this string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == '.' || c == '!' || c == '?')
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
        string text1 = "Hello! How are you?";
        string text2 = "This is a test string. It has multiple sentences.";

        Console.WriteLine($"Number of sentences in '{text1}': {text1.CountSentences()}"); 
        Console.WriteLine($"Number of sentences in '{text2}': {text2.CountSentences()}"); 
    }
}

