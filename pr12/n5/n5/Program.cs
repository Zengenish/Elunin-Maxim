using System;

public class Settings
{
    public static readonly string ConfigFilePath;

    static Settings()
    {
        ConfigFilePath = "C:\\user\\settings.json";
    }

    public static void ShowConfigPath()
    {
        Console.WriteLine($"Путь к файлу конфигурации: {ConfigFilePath}");
    }
}

class ProgramSettings
{
    static void Main()
    {
        Settings.ShowConfigPath();
        Console.ReadLine();
    }
}