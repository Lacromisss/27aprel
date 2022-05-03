using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderSystem;

namespace RestaurantSystem
{
    internal class ItemsMenuControl
    {
        Menu menu = new Menu();
        ConsoleKeyInfo itemCommand;
        public void ControlItemsMenu(IRestaurantManager manager)
        {
            bool menuItemActive = true;
            while (menuItemActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*---# Items Menu #---*");
                menu.ItemsMenu();
                itemCommand = Console.ReadKey();
                switch (itemCommand.KeyChar)
                {
                    case '1':
                        #region AddNewItem
                        Console.WriteLine("*---# Add new item #---*");
                        Console.WriteLine("Item name :");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Item price :");
                        string itemPriceStr = Console.ReadLine();
                        double itemPrice = itemPriceStr.DoubleInput("Item price", "Warn : Type of item price is double !");
                        Categories itemCategory = (Categories)1;
                        string itemCategoryStr;
                        bool itemCategoryIsCorrect = true;
                        while (itemCategoryIsCorrect)
                        {
                            Console.WriteLine("Item category \n(1-sup|2-anayemek|3-icki|4-desert) :");
                            itemCategoryStr = Console.ReadLine();
                            switch (itemCategoryStr)
                            {
                                case "1":
                                    itemCategory = Categories.Sup;
                                    itemCategoryIsCorrect = false;
                                    break;
                                case "2":
                                    itemCategory = Categories.AnaYemek;
                                    itemCategoryIsCorrect = false;
                                    break;
                                case "3":
                                    itemCategory = Categories.Icki;
                                    itemCategoryIsCorrect = false;
                                    break;
                                case "4":
                                    itemCategory = Categories.Desert;
                                    itemCategoryIsCorrect = false;
                                    break;
                                default:
                                    menu.WrongCommand();
                                    break;
                            }
                        }
                        manager.AddMenuItem(itemCategory, itemName, itemPrice);
                        #endregion
                        break;
                    case '2':
                        #region EditItem
                        Console.WriteLine("*---# Edit menu item #---*");
                        //  Item uzerinde duzelis et -  duzelis edilecek menuItem nomresi-u ve duzelis melumatlari(qiymet ve ad) daxil edilmelidir
                        Console.WriteLine("Enter number of menu item :");
                        string menuItemNo = Console.ReadLine();
                        Console.WriteLine("Item new price");
                        string newItemPriceStr = Console.ReadLine();
                        double newItemPrice = newItemPriceStr.DoubleInput("Item new price", "Warn : Type of item price is double!");
                        Console.WriteLine("Item name :");
                        string newitemName = Console.ReadLine();
                        manager.EditMenuItem(menuItemNo, newitemName, newItemPrice);

                        #endregion
                        break;
                    case '3':
                        #region RemoveMenuItem
                        Console.WriteLine("*---# Remove menu item #---*");
                        Console.WriteLine("Item no :");
                        string removeMenuItemNo = Console.ReadLine();
                        manager.RemoveMenuItem(removeMenuItemNo);
                        #endregion
                        break;
                    case '4':
                        #region ShowAllItem
                        Console.WriteLine("*---# Show all items #---*");
                        foreach (MenuItem item in manager.MenuItems)
                        {
                            Console.WriteLine($"Item name : {item.Name} - Item price : {item.Price} - Item no : {item.No}");
                        }
                        #endregion
                        break;
                    case '5':
                        #region ShowMenuItemByCategory
                        Console.WriteLine("*---# Show items (for Category) #---*");
                        Categories showItemCategory = (Categories)1;
                        string showItemCategoryStr;
                        bool showItemCategoryIsCorrect = true;
                        while (showItemCategoryIsCorrect)
                        {
                            Console.WriteLine("Item category \n(1-sup|2-anayemek|3-icki|4-desert) :");
                            showItemCategoryStr = Console.ReadLine();
                            switch (showItemCategoryStr)
                            {
                                case "1":
                                    showItemCategory = Categories.Sup;
                                    showItemCategoryIsCorrect = false;
                                    break;
                                case "2":
                                    showItemCategory = Categories.AnaYemek;
                                    showItemCategoryIsCorrect = false;
                                    break;
                                case "3":
                                    showItemCategory = Categories.Icki;
                                    showItemCategoryIsCorrect = false;
                                    break;
                                case "4":
                                    showItemCategory = Categories.Desert;
                                    showItemCategoryIsCorrect = false;
                                    break;
                                default:
                                    menu.WrongCommand();
                                    break;
                            }
                        }
                        foreach (MenuItem item in manager.GetMenuItemsByCategory(showItemCategory))
                        {
                            Console.WriteLine($"Item name : {item.Name} - Item price : {item.Price} - Item no : {item.No}");
                        }
                        #endregion
                        break;
                    case '6':
                        #region ShowItemsByPriceInterval
                        
                        Console.WriteLine("*---# Show items by prices interval #---*");
                        Console.WriteLine("Min price :");
                        string minPriceStr = Console.ReadLine();
                        double minPrice = minPriceStr.DoubleInput("Min price :", "Warn : Type of item price is double !");
                        Console.WriteLine("Max price :");
                        string maxPriceStr = Console.ReadLine();
                        double maxPrice = minPriceStr.DoubleInput("Max price :", "Warn : Type of item price is double !");
                        foreach (MenuItem item in manager.GetMenuItemsByPricesInterval(minPrice, maxPrice)) 
                        {
                            Console.WriteLine($"Item name : {item.Name} - Item price : {item.Price} - Item no : {item.No}");
                        }
                        #endregion
                        break;
                    case '7':
                        #region ShowItemsByName
                        Console.WriteLine("*---# Show menu items by name #---*");
                        Console.WriteLine("Item name :");
                        string searchName = Console.ReadLine();
                        foreach (MenuItem item in manager.GetMenuItemsByNameOrByNo(searchName,null))
                        {
                            Console.WriteLine($"Item name : {item.Name} - Item price : {item.Price} - Item no : {item.No}");
                        }
                        #endregion
                        break;
                    case '0':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sistem dayandirilsin ? y/n");
                        itemCommand = Console.ReadKey();
                        if (itemCommand.KeyChar == 'y')
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
