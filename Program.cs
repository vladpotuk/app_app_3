using System;

public static class IntExtensions
{
    public static Func<int, bool> IsEven = (number) => number % 2 == 0;

    public static bool IsEvenNumber(this int number)
    {
        return IsEven(number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} is even: {num1.IsEvenNumber()}"); 
        Console.WriteLine($"{num2} is even: {num2.IsEvenNumber()}"); 
    }
}
