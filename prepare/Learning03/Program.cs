using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDeciamlValue()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}\n{fraction2.GetDeciamlValue()}");

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDeciamlValue()}");

        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDeciamlValue()}");
    }
}