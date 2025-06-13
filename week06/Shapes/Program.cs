using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();

        Square square = new Square(20, "black");
        shapes.Add(square);

        Circle circle = new Circle(7, "red");
        shapes.Add(circle);

        Rectangule rectangule = new Rectangule(20, 10, "blue");
        shapes.Add(rectangule);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}km. B-)");
        }
    }
}