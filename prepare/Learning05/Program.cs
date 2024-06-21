using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Purple", 1);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Yellow", 2, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("Teal", 5);
        shapes.Add(s3);

        Console.WriteLine("Curious about these shapes?");
        Console.WriteLine("");

        foreach (Shape s in shapes)
        {
            double area = s.GetArea();

            string color = s.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}!");
        }
    }
}