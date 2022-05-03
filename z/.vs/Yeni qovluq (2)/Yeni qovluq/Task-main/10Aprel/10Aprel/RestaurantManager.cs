using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    public class RestaurantManager : IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddMenuItem(Categories category, string name, double price)
        {
            MenuItem menuItem = MenuItems.Find(menuItem => menuItem.Name == name);
            if (menuItem == null)
            {
                MenuItem newMenuItem = new MenuItem(category)
                {
                    Name = name,
                    Price = price,
                };
                MenuItems.Add(newMenuItem);
            }
            else
            {
                throw new AlreadyExistsException("Bu Menu Item Artiq Movcuddur !");
            }

        }

        public void AddOrder(Order order)
        {
            if (order != null)
            {
                Orders.Add(order);
            } else
            {
                throw new NullReferenceException("Order null-deyerdir!");
            }
        }
        public void EditMenuItem(string no, string newName, double newPrice)
        {
            MenuItem menuItem = MenuItems.Find(menuItem => menuItem.No == no);
            if (menuItem != null)
            {
                menuItem.Price = newPrice;
                menuItem.Name = newName;
            }
            else
            {
                throw new NotFoundException("Bele bir menu item yoxdur !");
            }
        }

        public List<MenuItem> GetMenuItemsByCategory(Categories category)
        {
            List<MenuItem> newMenuItems = MenuItems.FindAll(menuItem => menuItem.Category == category);
            if (newMenuItems != null)
            {
                return newMenuItems;
            }
            else
                throw new NotFoundException("Bu categoriyaya aid menu item yoxdur !");
        }

        public List<MenuItem> GetMenuItemsByNameOrByNo(string name, string no)
        {
            List<MenuItem> newMenuItems;
            if (no == null)
            {
                newMenuItems = MenuItems.FindAll(menuItem => menuItem.Name.Contains(name));
                return newMenuItems;
            }
            else if (name == null)
            {
                newMenuItems = MenuItems.FindAll(menuItem => menuItem.No.Contains(no));
                return newMenuItems;
            }
            else
            {
                throw new NotFoundException("Bu menuitem tapilmadi !");
            }

        }

        public List<MenuItem> GetMenuItemsByPricesInterval(double minPrice, double maxPrice)
        {
            List<MenuItem> newMenuItems;

            newMenuItems = MenuItems.FindAll(menuItem => menuItem.Price > minPrice && menuItem.Price < maxPrice);

            return newMenuItems;
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            List<Order> newOrders;

            newOrders = Orders.FindAll(order => order.Date == date);
            return newOrders;


        }

        public Order GetOrderByNo(int no)
        {
            Order newOrder;
            newOrder = Orders.Find(order => order.No == no);
            if(newOrder == null)
            {
                return null;
            }
            return newOrder;

        }

        public List<Order> GetOrdersByDatesInterval(DateTime fromDate, DateTime toDate)
        {
            List<Order> newOrders;

            newOrders = Orders.FindAll(order => order.Date >fromDate && order.Date<toDate);
            return newOrders;
        }

        public List<Order> GetOrdersByPriceInterval(double minPrice, double maxPrice)
        {
            List<Order> newOrders  = Orders.FindAll(order => order.TotalAmount > minPrice && order.TotalAmount < maxPrice);
            return newOrders;
        }

        public void RemoveMenuItem(string no)
        {
            MenuItem newMenuItem = MenuItems.Find(menuItem => menuItem.No == no);
            if (newMenuItem != null)
            {
                MenuItems.Remove(newMenuItem);
            }
        }

        public void RemoveOrder(int no)
        {
            Order newOrder = Orders.Find(order => order.No == no);
            if (newOrder != null)
            {
                Orders.Add(newOrder);
            }
        }
        
    }
}
