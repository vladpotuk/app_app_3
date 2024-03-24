
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction[] fractions = new Fraction[]
        {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(2, 5),
            new Fraction(5, 8),
            new Fraction(2, 3)
        };

        Fraction minFraction = fractions.FindMin();
        Fraction maxFraction = fractions.FindMax();

        Console.WriteLine($"Мінімальний дріб: {minFraction.Numerator}/{minFraction.Denominator}");
        Console.WriteLine($"Максимальний дріб: {maxFraction.Numerator}/{maxFraction.Denominator}");
    }
}
