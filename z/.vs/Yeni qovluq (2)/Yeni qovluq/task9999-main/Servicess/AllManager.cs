
using Modelss;
using System;
using System.Collections.Generic;
using System.Text;
using Order = Modelss.Order;

namespace Services
{
    public class AllManager : IRestaurantManager
    {

        
        public List<MenuItem> menuItems1= new List<MenuItem>();
       public  List<Order> order1= new List<Order>();
        //1
        public List<MenuItem> MenuItems()
        {
            return menuItems1;
        }
        //2
        public List<Order> Orders()
        {
           return order1;
        }
      //3
        public void RemoveOrder(int? num)
        {
            if (num== null)
            {
                throw new Exception("xetaa");
            }
            foreach (var item in order1)
            {
                if (item.No==num)
                {
                    order1.Remove(item);

                }

            }
            
        }
        //4
        public List<Order> GetOrdersByDatesInterval(DateTime min, DateTime max)
        {
            List<Order> newOrder = new List<Order>();
            foreach (var item in order1)
            {
                if (item.Date>min && item.Date<max)
                {
                    newOrder.Add(item);
                }

            }
            return newOrder;
        }
        //5
         public List<Order> GetOrderByDate(DateTime time)
        {
            List<Order> newOrder = new List<Order>();
            foreach (var item in order1)
            {
                if (item.Date==time)
                {
                    newOrder.Add(item);

                }

            }
            return newOrder;
        }
        //6
        public List<Order> GetOrdersByPriceInterval(double min, double max)
        {
            List<Order> newOrder = new List<Order>();
            foreach (var item in order1)
            {
                if (item.TotalAmount>min && item.TotalAmount<max)
                {
                    newOrder.Add(item);

                }

            }
            return newOrder;

        }
        //7
        public List<Order> GetOrderByNo(int? no)
        {
            List<Order> newOrder = new List<Order>();
            if (no==null)
            {
                throw new Exception("null");

            }
            foreach (var item in order1)
            {
                if (item.No==no)
                {
                    newOrder.Add(item);



                }

            }
            return newOrder;
        }
        //8
        public void AddMenuItem(string name, double price, Catagory a)
        {
            List<MenuItem> newMenuItems= new List<MenuItem>();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("xeta");

            }
            if (price<1)
            {
                throw new Exception("xetaaa");
            }
            MenuItem menuItem = new MenuItem()
            {
                Name = name,
                Price = price,
                catagory1 = a

            };
            newMenuItems.Add(menuItem);
            
        }
        //9
        public void RemoveMenuItem(int? no)
        {
            foreach (var item in menuItems1)
            {
                if (no==null)
                {
                    throw new Exception("xetaaaa");

                }
                if (item.No==no)
                {
                    menuItems1.Remove(item);

                }

            }
        }
        //10
        public List<MenuItem> EditMenuItem(int? no)
        {
            List<MenuItem> newMenuItem = new List<MenuItem>();
            if (no==null)
            {
                throw new Exception("xetaa");
            }
            foreach (var item in menuItems1)
            {
                if (item.No==no)
                {
                    item.Name = Console.ReadLine();
                    item.Price= Double.Parse( Console.ReadLine());
                    newMenuItem.Add(item);

                }

            }

            return newMenuItem;
        }
        //11
        public List<MenuItem> EditMenuItem(Catagory catagory)
        {
            List<MenuItem> newMenuItems = new List<MenuItem>();
            foreach (var item in menuItems1)
            {
                if (item.catagory1==Catagory.Sup)
                {
                    newMenuItems.Add(item);
                }
                

            }
            return newMenuItems;
        }
        //12
        public List<MenuItem> EditMenuItem(double min, double max)
        {
            List<MenuItem> newMenuItems = new List<MenuItem>();
            foreach (var item in menuItems1)
            {
                if (item.Price>min && item.Price<max)
                {
                    newMenuItems.Add(item);


                }

            }
            return newMenuItems;
        }

        public List<MenuItem> EditMenuItem(string text)
        {
            List<MenuItem> newMenuItem = new List<MenuItem>();
            foreach (var item in menuItems1)
            {
                if (item.Name==text)
                {
                    newMenuItem.Add(item);

                }

            }
            return newMenuItem;
        }

        List<MenuItem> IRestaurantManager.MenuItems()
        {
            throw new NotImplementedException();
        }

        List<MenuItem> IRestaurantManager.EditMenuItem(int? no)
        {
            throw new NotImplementedException();
        }

        List<MenuItem> IRestaurantManager.EditMenuItem(Catagory catagory)
        {
            throw new NotImplementedException();
        }

        List<MenuItem> IRestaurantManager.EditMenuItem(double min, double max)
        {
            throw new NotImplementedException();
        }

        List<MenuItem> IRestaurantManager.EditMenuItem(string text)
        {
            throw new NotImplementedException();
        }
    }
}
