﻿// See https://aka.ms/new-console-template for more information
var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    private Shape()
    {
        System.Console.WriteLine("Shape Constructor without side");
    }

    public Shape(int NumOfSide) : this()
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0)
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // Added 3 as a parameter
    {
        System.Console.WriteLine("This is a triangle");
    }
}
