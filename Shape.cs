/*
 *  CC# Program to Demonstrate Abstract Properties
 */
using System;
 
public abstract class Shape
{
    private string myId;
 
    public Shape(string s)
    {
        Id = s;  
    }
 
    public string Id
    {
        get
        {
            return myId;
        }
 
        set
        {
            myId = value;
        }
    }
    public abstract double Area
    {
        get;
    }
 
    public override string ToString()
    {
        return Id + " Area = " + string.Format("{0:F2}", Area);
    }
}
public class Square : Shape
{
    private int mySide;
 
    public Square(int side, string id)
        : base(id)
    {
        mySide = side;
    }
 
    public override double Area
    {
        get
        {
            // Given the side, return the area of a square:
            return mySide * mySide;
        }
    }
}
 
public class Circle : Shape
{
    private int myRadius;
 
    public Circle(int radius, string id)
        : base(id)
    {
        myRadius = radius;
    }
 
    public override double Area
    {
        get
        {
            // Given the radius, return the area of a circle:
            return myRadius * myRadius * System.Math.PI;
        }
    }
}
 
public class Rectangle : Shape
{
    private int myWidth;
    private int myHeight;
 
    public Rectangle(int width, int height, string id)
        : base(id)
    {
        myWidth = width;
        myHeight = height;
    }
 
    public override double Area
    {
        get
        {
            // Given the width and height, return the area of a rectangle:
            return myWidth * myHeight;
        }
    }
}
public class TestClass
{
    public static void Main()
    {
        Shape[] shapes =
         {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
         };
 
        System.Console.WriteLine("Shapes Collection");
        foreach (Shape s in shapes)
        {
            System.Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}