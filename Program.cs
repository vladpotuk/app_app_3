using System;

public static class IntExtensions
{
    public static Func<int, bool> IsOdd = (number) => number % 2 != 0;

    public static bool IsOddNumber(this int number)
    {
        return IsOdd(number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} is odd: {num1.IsOddNumber()}"); 
        Console.WriteLine($"{num2} is odd: {num2.IsOddNumber()}"); 
    }
}
