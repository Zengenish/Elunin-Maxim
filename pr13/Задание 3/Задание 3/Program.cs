using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(string title, string author, int year, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Статус доступности: {(IsAvailable ? "Доступен" : "Недоступен")}");
        }
    }
    public class Book : LibraryItem
    {
        public int PageCount { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int year, int pageCount, string isbn, bool isAvailable = true)
            : base(title, author, year, isAvailable)
        {
            PageCount = pageCount;
            ISBN = isbn;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество страниц: {PageCount}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Periodicity { get; set; }

        public Magazine(string title, string author, int year, int issueNumber, string periodicity, bool isAvailable = true)
            : base(title, author, year, isAvailable)
        {
            IssueNumber = issueNumber;
            Periodicity = periodicity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Номер выпуска: {IssueNumber}");
            Console.WriteLine($"Периодичность: {Periodicity}");
        }
    }
    public class DVD : LibraryItem
    {
        public int DurationMinutes { get; set; }
        public string Rating { get; set; }

        public DVD(string title, string director, int year, int durationMinutes, string rating, bool isAvailable = true)
            : base(title, director, year, isAvailable)
        {
            DurationMinutes = durationMinutes;
            Rating = rating;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Продолжительность: {DurationMinutes} минут");
            Console.WriteLine($"Рейтинг: {Rating}");
        }
    }
    public class Audiobook : LibraryItem
    {
        public int DurationMinutes { get; set; }
        public string Narrator { get; set; }
        public Audiobook(string title, string author, int year, int durationMinutes, string narrator, bool isAvailable = true)
            : base(title, author, year, isAvailable)
        {
            DurationMinutes = durationMinutes;
            Narrator = narrator;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Длительность: {DurationMinutes} минут");
            Console.WriteLine($"Диктор: {Narrator}");
        }
    }
    class Program
    {
        static void Main()
        {
            var book = new Book("Война и мир", "Лев Толстой", 1869, 1225, "1111111");
            var magazine = new Magazine("Наука и жизнь", "Редакция", 2023, 5, "Месячный");
            var dvd = new DVD("Интерстеллар", "Кристофер Нолан", 2014, 169, "222222");
            var audiobook = new Audiobook("Мастер и Маргарита", "Михаил Булгаков", 1967, 720, "Игорь Кваша");

            book.DisplayInfo();
            Console.WriteLine();

            magazine.DisplayInfo();
            Console.WriteLine();

            dvd.DisplayInfo();
            Console.WriteLine();

            audiobook.DisplayInfo();
        }
    }
}
