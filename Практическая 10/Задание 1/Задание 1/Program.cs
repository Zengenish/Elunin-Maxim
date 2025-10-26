using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 1)
                    pages = 1;
                else if (value > 5000)
                    pages = 5000;
                else
                    pages = value;
            }
        }
        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
        }
        public Book(string title) : this(title, 100)
        {
        }
        public Book() : this("Без названия", 1)
        {

        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Война и мир", 1200);
            Book book2 = new Book("1984");
            Book book3 = new Book();

            book1.Read();
            book2.Read();
            book3.Read();

            book1.Pages = 0;
            book1.Read();
        }
    }
}
