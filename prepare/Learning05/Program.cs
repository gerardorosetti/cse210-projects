using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 3);
        Console.WriteLine($"The {square.GetColor()} square has an area of {square.GetArea()}.");

        Rectangle rectangle = new Rectangle("green", 4, 5);
        Console.WriteLine($"The {rectangle.GetColor()} rectangle has an area of {rectangle.GetArea()}.");

        Circle circle = new Circle("Gray", 6);
        Console.WriteLine($"The {circle.GetColor()} circle has an area of {circle.GetArea()}.");
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}