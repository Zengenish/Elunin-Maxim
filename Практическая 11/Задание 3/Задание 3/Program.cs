using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{

    class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Название не может быть пустым!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public int Pages { get; set; } = 1;

        public bool IsLong
        {
            get { return Pages > 300; }
        }

        public Book(string title)
        {
            Title = title;
        }

        public void Info()
        {
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {(IsLong ? "да" : "нет")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Война и мир");
            myBook.Pages = 1200;
            myBook.Info();

            Book emptyBook = new Book(""); 
            emptyBook.Pages = 10;
            emptyBook.Info();

            Book shortBook = new Book("Краткая история");
            shortBook.Pages = 1;
            shortBook.Info();
            Console.ReadKey();
        }
    }
}