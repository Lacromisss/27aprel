using System;
using System.Collections.Generic;
using System.Text;

namespace _07042022
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} AuthorName:{AuthorName} Price: {Price} Id: {Id}");
        }

    }
}
