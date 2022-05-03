using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FilterByPrice(double minPrice,double maxPrice)
        {
            List<Book> newBooks = Books.FindAll(book => book.Price > minPrice && book.Price < maxPrice);
            return newBooks;
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            List<Book> newBooks = Books.FindAll(book => book.Genre == genre);
            return newBooks;
        }
        public Book FindBookByNo(int No)
        {
            Book result = Books.Find(book => book.No == No);
            if (result == null)
                return null;
            else 
                return result;
        }
    }
}
