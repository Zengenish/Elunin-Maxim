using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Course(string title, string description, string author, decimal price)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название курса: {Title}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Цена: {Price} руб.");
        }
    }
    public class VideoCourse : Course
    {
        public int VideoCount { get; set; }
        public TimeSpan TotalDuration { get; set; }

        public VideoCourse(string title, string description, string author, decimal price, int videoCount, TimeSpan totalDuration)
            : base(title, description, author, price)
        {
            VideoCount = videoCount;
            TotalDuration = totalDuration;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество видео: {VideoCount}");
            Console.WriteLine($"Общая длительность: {TotalDuration}");
        }
    }
    public class TextCourse : Course
    {
        public int ChapterCount { get; set; }
        public int TotalPages { get; set; }

        public TextCourse(string title, string description, string author, decimal price, int chapterCount, int totalPages)
            : base(title, description, author, price)
        {
            ChapterCount = chapterCount;
            TotalPages = totalPages;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество глав: {ChapterCount}");
            Console.WriteLine($"Общий объем текста: {TotalPages} страниц");
        }
    }
    public class InteractiveCourse : Course
    {
        public int ExerciseCount { get; set; }
        public string AssessmentSystem { get; set; }

        public InteractiveCourse(string title, string description, string author, decimal price, int exerciseCount, string assessmentSystem)
            : base(title, description, author, price)
        {
            ExerciseCount = exerciseCount;
            AssessmentSystem = assessmentSystem;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество упражнений: {ExerciseCount}");
            Console.WriteLine($"Система проверки: {AssessmentSystem}");
        }
    }
    class Program
    {
        static void Main()
        {
            var videoCourse = new VideoCourse("Программирование на C#", "Курс по C#", "Иван Иванов", 1999, 50, new TimeSpan(20, 0, 0));
            var textCourse = new TextCourse("История России", "Обзор истории России", "Петр Петров", 999, 10, 300);
            var interactiveCourse = new InteractiveCourse("Математика для начальной школы", "Курс по математике", "Мария Иванова", 1499, 30, "Автоматическая проверка");

            videoCourse.DisplayInfo();
            Console.WriteLine();

            textCourse.DisplayInfo();
            Console.WriteLine();

            interactiveCourse.DisplayInfo();
        }
    }
}
