using System;

abstract class Shape
{
    public abstract string Draw();
}

class Circle : Shape
{
    public override string Draw()
    {
        return "Рисую круг";
    }
}

class Triangle : Shape
{
    public override string Draw()
    {
        return "Рисую треугольник";
    }
}

class ProgramShapes
{
    static void Main()
    {
        Shape[] shapes = { new Circle(), new Triangle() };
        foreach (var s in shapes)
        {
            Console.WriteLine(s.Draw());
        }
        Console.ReadLine();
    }
}