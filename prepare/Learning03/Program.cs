using System;

class Program
{
    static void Main(string[] args)
    {
        mrtFraction oneFraction = new mrtFraction(_wholeNumber:1);
        mrtFraction fiveFraction = new mrtFraction(_wholeNumber:5);
        mrtFraction threeOverFourFraction = new mrtFraction(3, 4);
        mrtFraction oneOverThreeFraction = new mrtFraction(1, 3);
        Console.WriteLine(oneFraction.mrtGetFractionString());
        Console.WriteLine(oneFraction.mrtGetDecimalValue());
        Console.WriteLine(fiveFraction.mrtGetFractionString());
        Console.WriteLine(fiveFraction.mrtGetDecimalValue());
        Console.WriteLine(threeOverFourFraction.mrtGetFractionString());
        Console.WriteLine(threeOverFourFraction.mrtGetDecimalValue());
        Console.WriteLine(oneOverThreeFraction.mrtGetFractionString());
        Console.WriteLine(oneOverThreeFraction.mrtGetDecimalValue());
    }
}