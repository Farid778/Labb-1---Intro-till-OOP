using Labb_1___Intro_till_OOP;

internal class Program
{
    static void Main(string[] args)
    {

        Circle circle = new Circle(5);
        circle.GetArea();
        Console.WriteLine($"Area of the circle: {circle.GetArea()}");

        Circle circle2 = new Circle(6);
        circle2.GetArea();
        Console.WriteLine($"Area of the second circle: {circle2.GetArea()}");
    }

}

    
