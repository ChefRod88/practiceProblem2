using System;

class Program
{
    static void Main()
    {
        // Accepting input for the number of ounces
        Console.Write("Enter the number of ounces: ");
        int ounces = int.Parse(Console.ReadLine());

        // Defining constants for conversion
        int ouncesInPound = 16;
        int ouncesInTon = 32000;

        // Calculating tons
        int tons = ounces / ouncesInTon;
        int remainingOunces = ounces % ouncesInTon;

        // Calculating pounds
        int pounds = remainingOunces / ouncesInPound;

        // Calculating remaining ounces
        remainingOunces = remainingOunces % ouncesInPound;

        // Outputting the results
        Console.WriteLine($"Tons: {tons}");
        Console.WriteLine($"Pounds: {pounds}");
        Console.WriteLine($"Ounces: {remainingOunces}");
    }
}