using System;

public static class IntArrayExtensions
{
    public static int[] Filter(this int[] array, Func<int, bool> predicate)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (predicate(num))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        foreach (int num in array)
        {
            if (predicate(num))
            {
                result[index++] = num;
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

       
        int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        
        int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
        Console.WriteLine("Odd numbers:");
        foreach (int num in oddNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
