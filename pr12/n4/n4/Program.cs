using System;

public class Book
{
    public readonly string ISBN;
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
    }
}

class ProgramBook
{
    static void Main()
    {
        Book myBook = new Book("978-3-16-148410-0", "Книга", "Автор");
        myBook.ShowInfo();
        Console.ReadLine();
    }
}