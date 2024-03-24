public static class FractionExtensions
{
    public static Fraction FindMin(this Fraction[] fractions)
    {
        Fraction minFraction = fractions[0];

        foreach (Fraction fraction in fractions)
        {
            if ((double)fraction.Numerator / fraction.Denominator < (double)minFraction.Numerator / minFraction.Denominator)
            {
                minFraction = fraction;
            }
        }

        return minFraction;
    }

    public static Fraction FindMax(this Fraction[] fractions)
    {
        Fraction maxFraction = fractions[0];

        foreach (Fraction fraction in fractions)
        {
            if ((double)fraction.Numerator / fraction.Denominator > (double)maxFraction.Numerator / maxFraction.Denominator)
            {
                maxFraction = fraction;
            }
        }

        return maxFraction;
    }
}
