using System;

public static class IntExtensions
{
    public static bool IsFibonacci(this int number)
    {
        if (number == 0 || number == 1)
            return true;

        int a = 0;
        int b = 1;

        while (b < number)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b == number;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        int[] testNumbers = { 5, 8, 10, 13, 15, 21 };

        foreach (int number in testNumbers)
        {
            Console.WriteLine($"{number} is{(number.IsFibonacci() ? "" : " not")} a Fibonacci number.");
        }
    }
}
