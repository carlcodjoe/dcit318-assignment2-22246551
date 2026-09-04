// Abstract class Shape defines a contract: any concrete shape
// must provide its own way of calculating area. Because Shape
// itself isn't a "real" shape, it can't be instantiated directly.
abstract class Shape
{
    public abstract double GetArea();
}

// Circle implements GetArea() using the standard formula: pi * r^2.
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle implements GetArea() using length * width.
class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a circle with radius 5 and a rectangle with sides 4 and 6.
        // Even though both are treated as Shape references conceptually,
        // each calls its own version of GetArea().
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
    }
}