namespace TurkcellOdevOpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculating the area of shapes

            IShape[] shapes = {
                new Triangle(10, 10),
                new Square(0.60),
                new Rectangle(10, 20),
                new Circle(4)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.Area());
                
            }
        }
    }
}



interface IShape
{
    double Area();
}

class Triangle : IShape
{
    public Triangle(double _base, double _height)
    {
        Base = _base; Height = _height;
    }
    private double Base { get; set; }
    private double Height { get; set; }
    public double Area()
    {
        return Height * Base * 0.5;
    }
}
class Square : IShape
{
    public Square(double _base)
    {
        Base = _base;
    }

    private double Base { get; set; }

    public double Area()
    {
        return Base * Base;
    }

}
class Rectangle : IShape
{

    public Rectangle(double _width, double _height)
    {
        Width = _width;
        Height = _height;
    }

    public double Area()
    {
        return Width * Height;
    }

    private double Width { get; set; }
    private double Height { get; set; }
}

class Circle : IShape
{
    public Circle(double _radius)
    {
        radius = _radius;
    }

    public double Area()
    {
        return radius * radius * Math.PI;
    }

    private double radius { get; set; }
}