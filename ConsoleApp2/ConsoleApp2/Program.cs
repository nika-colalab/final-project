using System;
using System.Collections.Generic;

class Book
{

    public string Titel { get; set; }
    public string Autor { get; set; }
    public int PubYear { get; set; }

    public Book(string title, string ator, int pubYear)
    {
        Titel = title;
        Autor = autor;
        PubYear = pubYear;
    }

    public override string ToString()
    {
        return $"Title: {Titel}, Autor: {Autor}, Year: {PubYear}";
    }
}

class BookManagr
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book bk)
    {
        books.Add(bk);
        Console.WriteLine("Book added sucesfuly.");
    }

    public void ShowAll()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in teh list.");
            return;
        }

        Console.WriteLine("All book list:");
        foreach (var b in books)
        {
            Console.WriteLine(b.ToString());
        }
    }

    public Book FindByTitel(string titel)
    {
        foreach (var b in books)
        {
            if (b.Titel.ToLower() == titel.ToLower())
                return b;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        BookManagr managr = new BookManagr();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Chose action:");
            Console.WriteLine("1 - Add new book");
            Console.WriteLine("2 - Show all bookss");
            Console.WriteLine("3 - Seach by titel");
            Console.WriteLine("4 - Exit");
            Console.Write("Ur choise: ");

            string choise = Console.ReadLine();
            Console.WriteLine();

            if (choise == "1")
                AddBookUI(managr);
            else if (choise == "2")
                managr.ShowAll();
            else if (choise == "3")
                SearchUI(managr);
            else if (choise == "4")
            {
                Console.WriteLine("Program ended.");
                break;
            }
            else
                Console.WriteLine("Pls enter currect option (1-4).");
        }
    }

    static void AddBookUI(BookManagr managr)
    {
        Console.Write("Enter titel: ");
        string titel = Console.ReadLine();

        Console.Write("Enter autor: ");
        string autor = Console.ReadLine();

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Book bk = new Book(titel, autor, year);
        managr.AddBook(bk);
    }

    static void SearchUI(BookManagr managr)
    {
        Console.Write("Enter titel to seach: ");
        string titel = Console.ReadLine();

        Book found = managr.FindByTitel(titel);

        if (found != null)
            Console.WriteLine("Book finded: " + found);
        else
            Console.WriteLine("Book not found, sory.");
    }
}
