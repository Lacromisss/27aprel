using System;

namespace _05042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* ---------- * ---------- *");
            Console.WriteLine("|         Mushvig         |");
            Console.WriteLine("* ---------- * ---------- *");
            // Book 1
            Book book = new Book();
            book.AuthorName = "Shukurov Mushvig";
            book.Genre = Genre.Genre1;
            book.Name = "Azadliq Yoxdur !";
            book.Price = 55.5;
            // Book 2
            Book book2 = new Book();
            book2.AuthorName = "Beli, Men Ozum";
            book2.Genre = Genre.Genre1;
            book2.Name = "Feministler";
            book2.Price = 45.5;
            // Library
            Library library = new Library();
            library.Books.Add(book);
            library.Books.Add(book2);
            // Find By No
            Book findBook = library.FindBookByNo(1);
            Console.WriteLine($"Name : {findBook.Name}\nNo : {findBook.No}");
        }
    }
}
