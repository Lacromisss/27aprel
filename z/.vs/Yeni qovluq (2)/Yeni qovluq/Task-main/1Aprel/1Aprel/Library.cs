using System;
using System.Collections.Generic;
using System.Text;

namespace _1Aprel
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                {
                    NewBooks.Add(book);
                }
            }
            return NewBooks;
        }
        public void RemoveAllBookByName(string value)
        {
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                {
                    Books.Remove(book);
                }
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int minPC, int maxPC)
        {
            List<Book> NewList = new List<Book>();
            foreach (Book book in Books)
            {
                if(book.PageCount>minPC && book.PageCount < maxPC)
                {
                    NewList.Add(book);
                }
            }
            return NewList;
        }
        public void RemoveByCode(int value)
        {
            foreach (Book book in Books)
            {
                if (book.No == value)
                {
                    Books.Remove(book);
                }
            }
        }
        public List<Book> SearchBooks(string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book book in Books)
            {
                string text = book.Name + book.AuthorName + book.PageCount;
                if (text.Contains(value))
                {
                    NewBooks.Add(book);
                }
            }
            return NewBooks;
        }
    }
}

