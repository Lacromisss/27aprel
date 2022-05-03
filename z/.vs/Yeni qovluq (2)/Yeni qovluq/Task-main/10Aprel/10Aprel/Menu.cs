using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("1. Items Menu");
            Console.WriteLine("2. Orders menu");
            Console.WriteLine("0. Quit");
        }
        public void ItemsMenu()
        {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Edit Item");
            Console.WriteLine("3. Remove Item");
            Console.WriteLine("4. Show Items");
            Console.WriteLine("5. Get Items By Category");
            Console.WriteLine("6. Get Items By Prices Interval");
            Console.WriteLine("7. Get Item By Name");
            Console.WriteLine("0. Main Menu");

        }
        public void OrdersMenu()
        {
            Console.WriteLine("1. Add New Order");
            Console.WriteLine("2. Remove Order by No");
            Console.WriteLine("3. Show Orders");
            Console.WriteLine("4. Show Orders By Dates Interval");
            Console.WriteLine("5. Show Orders By Prices Interval");
            Console.WriteLine("6. Show Orders By Date");
            Console.WriteLine("7. Get Order By No");
            Console.WriteLine("0. Main Menu");
        }
        public void WrongCommand()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Yanlis Deneme !");
        }
    }
}
