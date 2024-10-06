using System;
using System.Collections.Generic;

// Prototype
public abstract class Shape
{
    public string Color { get; set; }
    public abstract Shape Clone();
}

// Concrete Prototype
public class Circle : Shape
{
    public double Radius { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Circle: Color={Color}, Radius={Radius}";
    }
}

// Concrete Prototype
public class Square : Shape
{
    public double Side { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Square: Color={Color}, Side={Side}";
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        // Create a circle
        Circle circle = new Circle { Color = "Red", Radius = 5 };
        Circle clonedCircle = (Circle)circle.Clone();
        Console.WriteLine(circle);
        Console.WriteLine(clonedCircle);

        // Create a square
        Square square = new Square { Color = "Blue", Side = 4 };
        Square clonedSquare = (Square)square.Clone();
        Console.WriteLine(square);
        Console.WriteLine(clonedSquare);
    }
}
