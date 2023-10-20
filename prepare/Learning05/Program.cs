using System;

class Program
{
    static void Main(string[] args)
    {
        string color = "red";
        float side = 5;
        Square square = new Square(color, side);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(color, side, 10);
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());

        Circle circle = new Circle("blue", side);
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }




    }
}