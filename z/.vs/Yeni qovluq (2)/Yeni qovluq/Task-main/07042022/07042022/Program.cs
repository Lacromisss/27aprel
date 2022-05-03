using Newtonsoft.Json;
using System;
using System.IO;

namespace _07042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* --- $ --- *");
            Console.WriteLine("|  Mushvig  |");
            Console.WriteLine("* --- * --- *");
            Console.WriteLine("\n----------------------------* Start *----------------------------\n");
            Library library = new Library()
            {
                Name = "ShukurovMushvig",
                Id = 703,
            };
            // Path
            string path = @"C:\Users\User\Desktop\codeacademy\07042022\07042022\";
            // Enter Folder Name
            Console.WriteLine("Folder name daxil edin :");
            string folderName = Console.ReadLine();
            // Folder Exists
            if (!Directory.Exists(path + folderName))
            {
                Directory.CreateDirectory(path + folderName);
            }
            else
            {
                Console.WriteLine($"{folderName} -adli folder var!");
            }

            // Create Database.json
            if (!File.Exists(path + folderName + @"\Database.json"))
            {
                var createFile = File.Create(path + folderName + @"\Database.json");
                createFile.Close();
            }
            else
            {
                Console.WriteLine("Database.json - adli file var!");
            }

            bool menuIsActive = true;
            while (menuIsActive)
            {
                Console.WriteLine("Menu :\n1. Add book\n2. Get book by id\n3. Remove book\n0. Quit");
                Console.WriteLine("Secim Edin :");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        menuIsActive = false;
                        break;
                    case "1":
                        int bookId = IntInput("Book Id Daxil Edin :", "Book Id Dogru Daxil Edin :");
                        string bookName = StringInput("Book Name Daxil Edin :");
                        string bookAuthorName = StringInput("Book AuthorName Daxil Edin :");
                        double bookPrice = DoubleInput("Book Price Daxil Edin :", "Book Price Dogru Daxil Edin :");
                        Book book = new Book()
                        {
                            Id = bookId,
                            Name = bookName,
                            Price = bookPrice,
                            AuthorName = bookAuthorName,
                        };
                        library.AddBook(book);
                        // Serialize Hissesi :
                        var json = JsonConvert.SerializeObject(library);
                        // Add Database.Json
                        using(StreamWriter sw = new StreamWriter(path + folderName + @"\Database.json"))
                        {
                            sw.WriteLine(json);
                        }
                        
                        break;
                    case "2":
                        int enterId = IntInput("Id Daxil Edin :", "Id -dogru formatda daxil edin :");
                        // Read DataBase.json                        
                        using (StreamReader sw = new StreamReader(path + folderName + @"\Database.json"))
                        {
                            var content = sw.ReadToEnd();
                            // DeSerialize
                            var jsonDecode = JsonConvert.DeserializeObject<Library>(content);
                            jsonDecode.GetBookById(enterId).ShowInfo();
                        }                        
                        break;
                    case "3":
                        int enterNewId = IntInput("Id Daxil Edin :", "Id -dogru formatda daxil edin :");
                        string newLibrary = null;
                        using (StreamReader sw = new StreamReader(path + folderName + @"\Database.json"))
                        {
                            var content = sw.ReadToEnd();
                            // DeSerialize
                            var jsonDecode = JsonConvert.DeserializeObject<Library>(content);
                            jsonDecode.RemoveBook(enterNewId);
                            // Serialize Hissesi :
                            var jsonEncode = JsonConvert.SerializeObject(jsonDecode);
                            newLibrary = jsonEncode;
                        }                       
                        // Add Database.Json
                        using (StreamWriter sw = new StreamWriter(path + folderName + @"\Database.json"))
                        {
                            sw.WriteLine(newLibrary);
                        }
                        break;
                    default:

                        break;
                }
            }
        }
        static int IntInput(string message1, string message2)
        {
            Console.WriteLine(message1);
            string inputStr = Console.ReadLine();
            int inputInt;
            while (!int.TryParse(inputStr, out inputInt))
            {
                Console.WriteLine(message2);
                inputStr = Console.ReadLine();
            }
            int.TryParse(inputStr, out inputInt);
            return inputInt;
        }
        static double DoubleInput(string message1, string message2)
        {
            Console.WriteLine(message1);
            string inputStr = Console.ReadLine();
            double inputDouble;
            while (!double.TryParse(inputStr, out inputDouble))
            {
                Console.WriteLine(message2);
                inputStr = Console.ReadLine();
            }
            double.TryParse(inputStr, out inputDouble);
            return inputDouble;
        }
        static string StringInput(string message)
        {
            Console.WriteLine(message);
            string inputStr = Console.ReadLine();
            return inputStr;
        }
        
    }
}
