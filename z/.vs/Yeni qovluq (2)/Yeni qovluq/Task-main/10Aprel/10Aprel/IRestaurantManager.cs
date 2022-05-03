using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    public interface IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<Order> Orders { get; set; }
        public void AddOrder(Order order);
        public void RemoveOrder(int no);
        public List<Order> GetOrdersByDatesInterval(DateTime fromDate,DateTime toDate);
        public List<Order> GetOrdersByDate(DateTime date);
        public List<Order> GetOrdersByPriceInterval(double minPrice,double maxPrice);
        public Order GetOrderByNo(int no);
        public void AddMenuItem(Categories category,string name,double price);
        public void RemoveMenuItem(string no);
        public void EditMenuItem(string no,string newName,double newPrice);
        public List<MenuItem> GetMenuItemsByCategory(Categories category);
        public List<MenuItem> GetMenuItemsByPricesInterval(double minPrice,double maxPrice);
        public List<MenuItem> GetMenuItemsByNameOrByNo(string name,string no);
    }
}
