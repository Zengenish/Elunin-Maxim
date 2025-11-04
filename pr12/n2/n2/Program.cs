using System;

public static class ProgramConfig
{
    public const string Version = "1.0.0";
    public const string Developer = "Елунин Максим";

    public static void ShowInfo()
    {
        Console.WriteLine($"Версия программы: {Version}");
        Console.WriteLine($"Разработчик: {Developer}");
    }
}

class ProgramConfigDemo
{
    static void Main()
    {
        Console.WriteLine("Информация о программе:");
        ProgramConfig.ShowInfo();
        Console.ReadLine();
    }
}