using System;

public class ObjectCounter
{
    private static int count = 0;

    public ObjectCounter()
    {
        count++;
    }

    public static void ShowCount()
    {
        Console.WriteLine($"Количество созданных объектов: {count}");
    }
}

class ProgramObjectCounter
{
    static void Main()
    {
        ObjectCounter obj1 = new ObjectCounter();
        ObjectCounter obj2 = new ObjectCounter();
        ObjectCounter.ShowCount();
        Console.ReadLine();
    }
}