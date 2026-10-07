using System;

public class Circle
{
    // Constant variable
    public const double PI = 3.14;

    // Methods to calculate area and perimeter
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        // Attempting to modify the constant variable will result in a compilation error:
        // Circle.PI = 3.14159; // Error CS0131: The left-hand side of an assignment must be a variable, property or indexer

        Console.WriteLine($"Circle PI: {Circle.PI}");
        Console.WriteLine($"Area (radius = 5): {Circle.CalculateArea(5)}");
        Console.WriteLine($"Perimeter (radius = 5): {Circle.CalculatePerimeter(5)}");
    }
}