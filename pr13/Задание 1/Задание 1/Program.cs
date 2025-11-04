using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary, DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Зарплата: {Salary}");
            Console.WriteLine($"Дата приема на работу: {HireDate.ToShortDateString()}");
        }
    }
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, DateTime hireDate, int teamSize)
            : base(name, "Manager", salary, hireDate)
        {
            TeamSize = teamSize;
        }

        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} проводит собрание с командой из {TeamSize} человек.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размер команды: {TeamSize}");
        }
    }
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, DateTime hireDate, string programmingLanguage)
            : base(name, "Developer", salary, hireDate)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пишет код на языке {ProgrammingLanguage}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Язык программирования: {ProgrammingLanguage}");
        }
    }
    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, DateTime hireDate, string department)
            : base(name, "Director", salary, hireDate)
        {
            Department = department;
        }
        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утверждает бюджет отдела {Department}.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
    }
    class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Иван Иванов", 80000, new DateTime(2015, 6, 1), 10);
            Developer developer = new Developer("Петр Петров", 60000, new DateTime(2018, 3, 15), "C#");
            Director director = new Director("Елена Еленова", 150000, new DateTime(2010, 1, 10), "IT");

            manager.DisplayInfo();
            manager.ConductMeeting();

            Console.WriteLine();

            developer.DisplayInfo();
            developer.WriteCode();

            Console.WriteLine();

            director.DisplayInfo();
            director.ApproveBudget();
        }
    }
}
