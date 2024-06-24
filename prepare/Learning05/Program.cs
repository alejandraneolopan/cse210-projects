using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes =  new List<Shape>();
        Square square1 = new Square("green", 0.5);
        shapes.Add(square1);
        Rectangle rect = new Rectangle("black", 5, 8);
        shapes.Add(rect);
        Circle circle = new Circle("red", 3);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}