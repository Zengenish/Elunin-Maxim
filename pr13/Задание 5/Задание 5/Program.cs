using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    public class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Среда обитания: {Habitat}");
            Console.WriteLine($"Рацион: {Diet}");
        }
    }
    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public int PregnancyDurationDays { get; set; }

        public Mammal(string species, int age, string habitat, string diet, string furType, int pregnancyDurationDays)
            : base(species, age, habitat, diet)
        {
            FurType = furType;
            PregnancyDurationDays = pregnancyDurationDays;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип меха: {FurType}");
            Console.WriteLine($"Продолжительность беременности: {PregnancyDurationDays} дней");
        }
    }
    public class Bird : Animal
    {
        public double WingspanMeters { get; set; }
        public string NestingType { get; set; }

        public Bird(string species, int age, string habitat, string diet, double wingspanMeters, string nestingType)
            : base(species, age, habitat, diet)
        {
            WingspanMeters = wingspanMeters;
            NestingType = nestingType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размах крыльев: {WingspanMeters} м");
            Console.WriteLine($"Тип гнездования: {NestingType}");
        }
    }
    public class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double EnvironmentTemperature { get; set; }

        public Reptile(string species, int age, string habitat, string diet, string skinType, double environmentTemperature)
            : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            EnvironmentTemperature = environmentTemperature;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип кожи: {SkinType}");
            Console.WriteLine($"Температура среды: {EnvironmentTemperature}°C");
        }
    }
    public class Fish : Animal
    {
        public string ScaleType { get; set; }
        public double DepthHabitatMeters { get; set; }

        public Fish(string species, int age, string habitat, string diet, string scaleType, double depthHabitatMeters)
            : base(species, age, habitat, diet)
        {
            ScaleType = scaleType;
            DepthHabitatMeters = depthHabitatMeters;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип чешуи: {ScaleType}");
            Console.WriteLine($"Глубина обитания: {DepthHabitatMeters} м");
        }
    }
    class Program
    {
        static void Main()
        {
            var lion = new Mammal("Лев", 5, "Саванна", "Мясо", "Короткий мех", 110);
            var eagle = new Bird("Орел", 3, "Горы", "Мясо", 2.1, "Дупла");
            var snake = new Reptile("Змея", 2, "Лес", "Грызуны", "Чешуя", 25);
            var salmon = new Fish("Лосось", 4, "Река", "Пища, планктон", "Крупные чешуи", 20);

            lion.DisplayInfo();
            Console.WriteLine();

            eagle.DisplayInfo();
            Console.WriteLine();

            snake.DisplayInfo();
            Console.WriteLine();

            salmon.DisplayInfo();
        }
    }
}
