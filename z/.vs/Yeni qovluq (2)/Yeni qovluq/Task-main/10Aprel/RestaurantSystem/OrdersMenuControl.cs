using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderSystem;

namespace RestaurantSystem
{
    internal class OrdersMenuControl
    {
        Menu menu = new Menu();

        ConsoleKeyInfo orderCommand;
        public void ControlOrdersMenu(IRestaurantManager manager)
        {
            bool menuItemActive = true;
            while (menuItemActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*---# Orders Menu #---*");
                menu.OrdersMenu();
                orderCommand = Console.ReadKey();
                switch (orderCommand.KeyChar)
                {
                    case '1':
                        List<OrderItem> orderItems = new List<OrderItem>();

                        List<MenuItem> menuItems = manager.MenuItems;
                        Console.WriteLine("|---* Menu items *---|");
                        foreach (MenuItem item in menuItems)
                        {
                            Console.WriteLine($"Item name : {item.Name} - Item price : {item.Price} - Item no : {item.No}");
                        }
                        Console.WriteLine("*---# Add new order item #---*");
                    enterMenuItemAndCount:
                        Console.WriteLine("Choose :");
                        string menuItemStr = Console.ReadLine();
                        MenuItem enteredMenuItem = null;
                        double totalAmont = 0;
                        if (menuItems.Find(menuItem => menuItem.Name.Contains(menuItemStr)) != null)
                        {
                            enteredMenuItem = menuItems.Find(menuItem => menuItem.Name.Contains(menuItemStr));

                            Console.WriteLine("Count :");
                            string menuItemCountStr = Console.ReadLine();
                            int menuItemCount = menuItemCountStr.IntInput("Enter item count :", "Warn : Item count is integer!");
                            OrderItem orderItem = new OrderItem()
                            {
                                MenuItem = enteredMenuItem,
                                Count = menuItemCount
                            };
                            totalAmont += enteredMenuItem.Price * menuItemCount;
                            orderItems.Add(orderItem);
                        }
                        else
                        {
                            Console.WriteLine("Warn : This item not founded !");
                        }


                        Console.WriteLine("Basqa sifaris etmek isteyirsiniz ? y/n");
                        ConsoleKeyInfo otherOrder = Console.ReadKey();
                        if (otherOrder.KeyChar == 'y')
                        {
                            goto enterMenuItemAndCount;
                        }
                        else if (otherOrder.KeyChar == 'n')
                        {
                            if (orderItems.Count != 0)
                            {
                                Order newOrder = new Order()
                                {
                                    Date = DateTime.Now,
                                    OrderItems = orderItems,
                                    TotalAmount = totalAmont
                                };
                                manager.AddOrder(newOrder);
                            }
                        }


                        break;
                    case '2':
                        Console.WriteLine("*---# Remove order item #---*");
                        Console.WriteLine("Enter order no :");
                        string orderNo = Console.ReadLine();
                        int orderNoInt = orderNo.IntInput("Enter order no :", "Warn: Order must be int!");
                        manager.RemoveOrder(orderNoInt);
                        break;
                    case '3':
                        Console.WriteLine("*---# Show All Orders #---*");
                        if (manager.Orders.Count != 0)
                        {
                            foreach (Order item in manager.Orders)
                            {
                                foreach (OrderItem orderItem in item.OrderItems)
                                {
                                    Console.WriteLine($"Menu Item Name : {orderItem.MenuItem.Name} - Count : {orderItem.Count} - Price : {orderItem.MenuItem.Price} - TotalAmount : {item.TotalAmount}");
                                }
                            }
                        }


                        break;
                    case '4':
                        Console.WriteLine("*---# Show Orders By Dates Interval #---*");
                        Console.WriteLine("Order FromDate :");
                        DateTime fromDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Order ToDate :");
                        DateTime toDate = DateTime.Parse(Console.ReadLine());
                        foreach (Order order in manager.GetOrdersByDatesInterval(fromDate, toDate))
                        {
                            Console.WriteLine($"Order No : {order.No} - Order Date : {order.Date} - Order item count: {order.OrderItems.Count} - Order Total Amount : {order.TotalAmount}");
                        }
                        break;
                    case '5':
                        Console.WriteLine("*---# Show Orders By Prices Interval #---*");
                        Console.WriteLine("Min price :");
                        string minPriceStr = Console.ReadLine();
                        double minPrice = minPriceStr.DoubleInput("Min price :", "Warn : Type of price is double !");
                        Console.WriteLine("Max price :");
                        string maxPriceStr = Console.ReadLine();
                        double maxPrice = minPriceStr.DoubleInput("Max price :", "Warn : Type of price is double !");

                        if (manager.Orders.Count != 0)
                        {
                            Console.WriteLine("*---# Sifarisler (minPrice - maxPrice) #---*");
                            foreach (Order orderler in manager.GetOrdersByPriceInterval(minPrice, maxPrice))
                            {
                                Console.WriteLine($"Order No : {orderler.No} - Order Date : {orderler.Date} - Order item count: {orderler.OrderItems.Count} - Order Total Amount : {orderler.TotalAmount}");
                            }
                        }


                        break;
                    case '6':
                        Console.WriteLine("*---# Show Orders By Date #---*");
                        Console.WriteLine("Order Date :");
                        DateTime Date = DateTime.Parse(Console.ReadLine());
                        foreach (Order order in manager.GetOrdersByDate(Date))
                        {
                            Console.WriteLine($"Order No : {order.No} - Order Date : {order.Date} - Order item count: {order.OrderItems.Count} - Order Total Amount : {order.TotalAmount}");
                        }
                        break;
                    case '7':
                        Console.WriteLine("*---# Show Order By No #---*");
                        Console.WriteLine("Order No :");
                        string getOrderByNoStr = Console.ReadLine();
                        int getOrderByNoInt = getOrderByNoStr.IntInput("Enter order no :", "Warn : Order no is int !");
                        Order getOrderNyNo = manager.GetOrderByNo(getOrderByNoInt);
                        Console.WriteLine($"Order No : {getOrderNyNo.No} - Order Date : {getOrderNyNo.Date} - Order item count: {getOrderNyNo.OrderItems.Count} - Order Total Amount : {getOrderNyNo.TotalAmount}");
                        break;
                    case '0':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sistem dayandirilsin ? y/n");
                        orderCommand = Console.ReadKey();
                        if (orderCommand.KeyChar == 'y')
                        {
                            menuItemActive = false;
                            Console.Clear();
                            Console.WriteLine("Esas Menyu !");
                            break;
                        }
                        else
                            Console.Clear();
                        break;
                    default:
                        menu.WrongCommand();
                        break;
                }
            }
        }
    }
}
