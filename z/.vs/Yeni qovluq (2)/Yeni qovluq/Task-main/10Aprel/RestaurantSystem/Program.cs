using System;
using RestaurantOrderSystem;
namespace RestaurantSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRestaurantManager mainManager = new RestaurantManager();
            Console.Title = "Restaurant System";
            Menu menu = new Menu();
            
            ItemsMenuControl ItemsMenuControl = new ItemsMenuControl();
            OrdersMenuControl OrdersMenuControl = new OrdersMenuControl();
            ConsoleKeyInfo command;            
            bool menuActive = true;
            while (menuActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                menu.MainMenu();
                command = Console.ReadKey();
                switch (command.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        ItemsMenuControl.ControlItemsMenu(mainManager);
                        break;
                    case '2':
                        Console.Clear();
                        OrdersMenuControl.ControlOrdersMenu(mainManager);
                        break;
                    case '0':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sistem dayandirilsin ? y/n");
                        command = Console.ReadKey();
                        if (command.KeyChar == 'y')
                        {
                            menuActive = false;
                            Console.Clear();
                            Console.WriteLine("Sistem dayandirildi !");
                            Console.WriteLine("Yene gozleyirik !");
                        }
                        else
                            Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yanlis Deneme !");
                        break;
                }
            }

        }
    }
}
