
using Modelss;

using System;
using System.Collections.Generic;
using MenuItem = Modelss.MenuItem;
using Order = Modelss.Order;

namespace Services
{
    public interface IRestaurantManager
    {

        public List<MenuItem> MenuItems();
        public List<Order> Orders();
        public void RemoveOrder(int? num);
        public List<Order> GetOrdersByDatesInterval(DateTime min, DateTime max);
        public List<Order> GetOrderByDate(DateTime time);
        public List<Order> GetOrdersByPriceInterval(double min, double max);
        public List<Order> GetOrderByNo(int? no);
        public void AddMenuItem(string name, double price, Catagory a);
        public void RemoveMenuItem(int? no);
        public List<MenuItem> EditMenuItem(int? no);
        public List<MenuItem> EditMenuItem(Catagory catagory);
        public List<MenuItem> EditMenuItem(double min, double max);
        public List<MenuItem> EditMenuItem(string text);








    }
}