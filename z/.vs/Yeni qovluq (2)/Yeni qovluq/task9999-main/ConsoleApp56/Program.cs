using Modelss;
using Services;
using System;
using System.Collections.Generic;



namespace HR_Systemm
{
    internal class Program
    {
        static IRestaurantManager _restaurantManager;




        static void Main(string[] args)
        {
            string menu;
            do
            {
                ShowMenu();
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        MenuItems();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Seciminiz 1,2 ve ya 3 ola biler!");
                        break;
                }

            } while (true);






        }
        static void ShowMenu()
        {
            Console.WriteLine("1 Menu uzerinde emeliyyat aparmaq");
            Console.WriteLine("2 Sifarisler uzerinde emeliyyat aparmaq");
            Console.WriteLine("0 Sistemden cixmaq");
        }
        static void MenuItems()
        {
            string submenu;
            do
            {


                Console.WriteLine("1 Yeni item elave et");
                Console.WriteLine("2 Item uzerinde duzelis et");
                Console.WriteLine("3 Item sil");
                Console.WriteLine("4 Butun Item-lari goster ");
                Console.WriteLine("5 Categoriyasina gore menu item-lari goster");
                Console.WriteLine("6 Qiymet araligina gore menu item-lar goster");
                Console.WriteLine("7 Menu item-lar arasinda ada gore axtaris et (search)");
                Console.WriteLine("0 Evvelki menuya qayit");
                submenu = Console.ReadLine();
                switch (submenu)
                {
                    case "1":
                        AllManager allManager = new AllManager();
                        Console.WriteLine("Name daxil edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price daxil edin");
                       double price=  double.Parse(Console.ReadLine());
                        Catagory catagory = Catagory.Sup;


                     allManager.AddMenuItem(name, price, catagory);
                     
                        break;
                    case "2":
                       


                        break;
                    case "3":
                      
                        AllManager allManager2 = new AllManager();
                        int no = int.Parse(Console.ReadLine());
                        allManager2.RemoveMenuItem(no);


                        break;
                    case "4":
                        AllManager all = new AllManager();
                        all.MenuItems();
                        break;
                    case "5":
                      AllManager allManager9= new AllManager();
                        int m=  int.Parse(Console.ReadLine());
                        int mi = int.Parse(Console.ReadLine());
                        allManager9.EditMenuItem(m, mi);

                        break;
                    case "6":
                        AllManager allManager6 = new AllManager();
                        int minn = int.Parse(Console.ReadLine());
                        int maxx = int.Parse(Console.ReadLine());
                        allManager6.EditMenuItem(minn, maxx);



                        break;
                    case "7":
                        AllManager allManager7 = new AllManager();
                        string text = Console.ReadLine();
                        allManager7.EditMenuItem(text);
                        break;
                    case "0":
                        break;
                }







            } while (true);








        }
        public void Orders()
        {
            string innput;
            do
            {
                 
          
            Console.WriteLine("1 Yeni sifaris elave etmek");
            Console.WriteLine("- 2 Sifarisin legvi ");
            Console.WriteLine("  - 3 Butun sifarislerin ekrana cixarilmas");
            Console.WriteLine("4 Verilen tarix araligina gore sifarislrein gosterilmes");
            Console.WriteLine("5 Verilen mebleg araligina gore sifarislerin gosterilmesi ");
            Console.WriteLine("6 Verilmis bir tarixde olan sifarislerin gosterilmesi ");
            Console.WriteLine("7 Verilmis nomreye esasen hemin nomreli sifarisin melumatlarinin gosterilmesi");
                innput = Console.ReadLine();
                switch (innput)
                {
                    case "1":
                      



                        break;
                    case "2":
                        




                        break;
                    case "3":


                        break;
                    case "4":
                     
                        break;
                    case "5":
                       

                        break;
                    case "6":
                       



                        break;
                    case "7":
                       
                        break;
                    case "0":
                        break;

                }


            } while (true);



        }
    }

}