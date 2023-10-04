using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Insert 1 number");
        int top = int.Parse(Console.ReadLine());
        Fraction fraction = new Fraction(top);
        Console.WriteLine($"Here's your fraction: {fraction.GetFractionString()} and your decimal value is {fraction.GetDecimalValue()}");

        Console.WriteLine("Insert one number");
        top = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert another number");
        int bottom = int.Parse(Console.ReadLine());
        fraction = new Fraction(top, bottom);
        Console.WriteLine($"Here's your fraction: {fraction.GetFractionString()} your numerator is {fraction.GetTop()} and your denominator is {fraction.GetBottom()} and your decimal value is {fraction.GetDecimalValue()}");
        





        
    }
}