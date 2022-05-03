using System;
using System.Collections.Generic;
using System.Text;

namespace _07042022
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BookList { get; set; } = new List<Book>();
        public void AddBook(Book book)
        {
            BookList.Add(book);
        }
        public Book GetBookById(int id)
        {
            return BookList.Find(x => x.Id == id);
        }
        public void RemoveBook(int id)
        {
            var book = BookList.Find(x => x.Id == id);
            BookList.Remove(book);
        }
    }
}
