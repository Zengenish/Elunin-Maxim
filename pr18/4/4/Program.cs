using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { Name = "Анна", Score = 95 },
            new Student { Name = "Пётр", Score = 95 },
            new Student { Name = "Ольга", Score = 88 },
            new Student { Name = "Иван", Score = 75 },
            new Student { Name = "Мария", Score = 75 },
            new Student { Name = "Алексей", Score = 88 },
            new Student { Name = "Светлана", Score = 95 }
        };

            var grouped = students
                .GroupBy(s => s.Score)
                .OrderByDescending(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Select(s => s.Name).ToList());

            foreach (var entry in grouped)
            {
                string names = string.Join(", ", entry.Value);
                Console.WriteLine($"{entry.Key}: {names}");
            }
        }
    }
}
