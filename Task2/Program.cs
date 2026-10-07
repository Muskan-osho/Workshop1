class Program
{
    static void Main()
    {
        // ADD THIS LINE TO TRIGGER THE ERROR:
        Circle.PI = 3.14159; 

        Console.WriteLine($"Circle PI: {Circle.PI}");
        Console.WriteLine($"Area (radius = 5): {Circle.CalculateArea(5)}");
        Console.WriteLine($"Perimeter (radius = 5): {Circle.CalculatePerimeter(5)}");
    }
}