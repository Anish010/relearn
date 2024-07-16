namespace StaticClass;
public class Mains
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Addition: " + Maths.Add(5, 3));
        Console.WriteLine("Subtraction: " + Maths.Subtract(5, 3));
        Console.WriteLine("Multiplication: " + Maths.Multiply(5, 3));
        Console.WriteLine("Division: " + Maths.Divide(5, 3));
        Console.WriteLine("Circle Area: " + Maths.CalculateCircleArea(5));
    }
}