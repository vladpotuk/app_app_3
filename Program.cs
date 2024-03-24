using System;

public static class IntExtensions
{
    public static bool IsPrime(this int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} is prime: {num1.IsPrime()}"); 
        Console.WriteLine($"{num2} is prime: {num2.IsPrime()}"); 
    }
}

