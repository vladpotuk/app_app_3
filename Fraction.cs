using System;

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменник не може бути нулем.", nameof(denominator));

        Numerator = numerator;
        Denominator = denominator;
    }
}
