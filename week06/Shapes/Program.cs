using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(new Square("blue", 2));
        shapes.Add(new Rectangle("red",5,3));
        shapes.Add(new Circle("green",2));

        foreach (Shapes shape in shapes)
        {
            string color= shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color of the shape is {color} and the area is {area}");
        }
    }
}