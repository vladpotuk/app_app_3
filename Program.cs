using System;

public static class IntExtensions
{
    public static Func<int, bool> IsEven = (number) => number % 2 == 0;
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} is even: {IntExtensions.IsEven(num1)}"); 
        Console.WriteLine($"{num2} is even: {IntExtensions.IsEven(num2)}"); 
    }
}

