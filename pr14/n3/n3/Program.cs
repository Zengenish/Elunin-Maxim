using System;

class Food
{
    public virtual void Eat()
    {
        Console.WriteLine("Едим...");
    }
}

class Pizza : Food
{
    public override void Eat()
    {
        Console.WriteLine("Едим пиццу!");
    }
}

class Burger : Food
{
    public override void Eat()
    {
        Console.WriteLine("Едим бургер!");
    }
}

class ProgramFood
{
    static void Main()
    {
        Food[] lunch = { new Pizza(), new Burger(), new Food() };
        foreach (var f in lunch)
        {
            f.Eat();
        }
        Console.ReadLine();
    }
}