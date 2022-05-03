using System;
using System.Collections.Generic;

namespace _1Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book()
            //{
            //    Name = "Evakuasiya",
            //    AuthorName = "Qaraqan",
            //    PageCount = 260
            //};
            //Book book2 = new Book()
            //{
            //    Name = "Cinayet ve Ceza",
            //    AuthorName = "Dostoyevski",
            //    PageCount = 700
            //};
            //Book book3 = new Book()
            //{
            //    Name = "Hic bir karsilasma tesaduf degildir",
            //    AuthorName = "Hakan Menguc",
            //    PageCount = 200
            //};

            //Book book4 = new Book()
            //{
            //    Name = "77-ci Gun",
            //    AuthorName = "Varis",
            //    PageCount = 300
            //};
            //Library libraff = new Library();
            //libraff.Books.Add(book1);
            //libraff.Books.Add(book2);
            //libraff.Books.Add(book3);
            //libraff.Books.Add(book4);

            //Console.WriteLine("Butun Kitablarin Siyahisi :");
            //foreach (Book book in libraff.Books)
            //{
            //    Console.WriteLine($"BookName : {book.Name} BookPageCount : {book.PageCount} BookAuthorName : {book.AuthorName}");
            //}
            //Console.WriteLine("Sehife Sayina Gore Filtirlenmis Kitablar");
            //foreach (Book book in libraff.FindAllBooksByPageCountRange(200, 650))
            //{
            //    Console.WriteLine($"BookName : {book.Name} BookPageCount : {book.PageCount} BookAuthorName : {book.AuthorName}");
            //}
            //Console.WriteLine("Book adina gore axtarisin neticeleri :");
            //foreach (Book book in libraff.FindAllBooksByName("yet"))
            //{
            //    Console.WriteLine($"BookName : {book.Name} BookPageCount : {book.PageCount} BookAuthorName : {book.AuthorName}");
            //}
            //Console.WriteLine("Name AuthorName ve PageCount icerisinde value axtarir");
            //foreach (Book book in libraff.SearchBooks("c20"))
            //{
            //    Console.WriteLine($"BookName : {book.Name} BookPageCount : {book.PageCount} BookAuthorName : {book.AuthorName}");
            //}
            Excercises();
        }
        static void Excercises()
        {
            Console.WriteLine("Shukurov Mushvig");
            Console.WriteLine("List Metodlar");
            List<int> ages = new List<int>();
            // Add metodu
            ages.Add(20);
            ages.Add(21);
            // Indekse gore get etmek
            Console.WriteLine(ages[0]);
            // Indekse gore set etmek
            ages[1] = 34;
            // Elementleri ekrana yazdirmaq
            foreach (int age in ages)
            {
                Console.WriteLine($"Age :| {age}");
            }
            // Remove Metodu - Elementi List-de axtarir ve silir
            ages.Remove(34);
            // RemoveAt Metodu - parametr olaraq gonderdiyimiz indeksdeki elementi silir
            ages.RemoveAt(0);
            // Elementleri yeniden ekrana yazdirmaq
            Console.WriteLine("Remove ve RemoveAt-dan sonra elementler");
            foreach (int age in ages)
            {
                Console.WriteLine($"Age :| {age}");
            }
            ages.Add(45);
            ages.Add(67);
            ages.Add(60);
            // AddRange Metodu Toplu elementi Liste Elave edir
            ages.AddRange(new List<int> { 12, 13, 14 });
            Console.WriteLine("AddRange sonrasi Elementleri ekrana yazdirmaq");
            foreach (int age in ages)
            {
                Console.WriteLine($"Age :| {age}");
            }
            // Capacity
            Console.WriteLine($"ages listinin capacity deyeri = {ages.Capacity}");
            // Count
            Console.WriteLine($"ages list-indeki element sayi = {ages.Count}");
            // Equals
            List<string> list1 = new List<string>(10);
            list1.Add("4");
            list1.Add("Body");
            List<string> list2 = new List<string>();
            list2 = list1;
            Console.WriteLine(list1.Equals(list2));
            // FindAll
            // Serte uygun olan butun parametrleri alir
            Console.WriteLine("FindAll Neticeleri");
            foreach (int age in ages.FindAll(isOdd)) // isOdd Metodunu asagida yazmisam
            {
                Console.WriteLine(age);
            }
            // Find metodu
            // Serte uygun olan ilk parametri alir
            Console.WriteLine("Find Metodunu calisdirdiqdan sonra");
            Console.WriteLine(ages.Find(isOdd));
            // FindLastIndex metodu
            // Serte uygun olan son elementin indeksini qaytarir
            Console.WriteLine("FindLastIndex Metodu");
            Console.WriteLine(ages.FindLastIndex(isOdd));
            // FindIndex metodu
            // Serte uygun olan ilk elementin indeksini qaytarir
            Console.WriteLine("FindIndex Metodu");
            Console.WriteLine(ages.FindIndex(isOdd));
            // Sort
            ages.Sort();
            Console.WriteLine("Sort olundu :");
            foreach (int age in ages)
            {
                Console.WriteLine($"Age : {age}");
            }
            // Reverse
            ages.Reverse();
            Console.WriteLine("Reverse olundu :");
            foreach (int age in ages)
            {
                Console.WriteLine($"Age : {age}");
            }
            // RemoveRange
            ages.RemoveRange(3,2); // 3-cu indeksden baslayir 2-sini silmeye | 3 ve 4 cu indeksdekiler silindi
            Console.WriteLine("RemoveRange Metodundan sonra :");
            foreach (int age in ages)
            {
                Console.WriteLine($"Age : {age}");
            }
        }
        static bool isOdd(int a)
        {
            if (a % 2 == 1)
                return true;
            return false;
        }
    }
}
