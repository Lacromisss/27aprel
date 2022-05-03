using System;
using System.Collections.Generic;
namespace _08042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("Menu :");
                Console.WriteLine($"1. Tələbə əlavə et\n2. Tələbəyə imtahan əlavə et\n3. Tələbənin bir imtahan balına bax\n" +
                    $"4. Tələbənin bütün imtahanlarını göstər\n5. Tələbənin imtahan ortalamasını göstər\n6. Tələbədən imtahan sil" +
                    $"\n0. Proqramı bitir\nChoose :");
                string command = Console.ReadLine();
                int no;
                string examName;
                Student searchStudent;
                switch (command)
                {
                    case "1":
                        Console.WriteLine("FullName :");
                        string fullName = Console.ReadLine();
                        Student student = new Student()
                        {
                            FullName = fullName,
                        };
                        students.Add(student);
                        break;
                    case "2":
                        no = IntInput("No :", "No int olsun :");
                        examName = StringInput("Exam Name :");
                        double point = DoubleInput("Point :", "Point double olsun :");
                        searchStudent = students.Find(std => std.No == no);
                        if(searchStudent != null)
                            searchStudent.AddExam(examName, point);
                        break;
                    case "3":
                        no = IntInput("Student No Daxil Edin :", "Student No Duzgun Daxil Edin :");
                        examName = StringInput("Exam Name :");
                        searchStudent = students.Find(std => std.No == no);
                        if(searchStudent != null)
                        {
                            Console.WriteLine($"{no} -nomreli telebenin {examName} -adli imtahan neticesi :");
                            Console.WriteLine(searchStudent.GetExamResult(examName));
                        }
                        
                        break;
                    case "4":
                        no = IntInput("Student No Daxil Edin :", "Student No Duzgun Daxil Edin :");
                        searchStudent = students.Find(std => std.No == no);
                        if (searchStudent != null)
                        {
                            Console.WriteLine($"{no} -nomreli telebenin imtahanlari ve ballari :");
                            foreach (var item in searchStudent.Exams)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }
                        }
                        
                        break;
                    case "5":
                        no = IntInput("Student No Daxil Edin :", "Student No Duzgun Daxil Edin :");
                        searchStudent = students.Find(std => std.No == no);
                        if (searchStudent != null)
                        {
                            Console.WriteLine($"{no} -nomreli telebenin imtahanlardan ortalama bali :");
                            Console.WriteLine(searchStudent.GetExamAvg());
                        }
                       
                        break;
                    case "6":
                        no = IntInput("No :", "No int olsun :");
                        examName = StringInput("Exam Name :");
                        searchStudent = students.Find(std => std.No == no);
                        if(searchStudent != null)
                        {
                            if (searchStudent.Exams.ContainsKey(examName))
                            {
                                searchStudent.Exams.Remove(examName);
                                Console.WriteLine($"{no} -nomreli telebeden {examName} -adli imtahan silindi .");
                            }                            
                        }
                        
                        break;
                    case "0":
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis Deneme !");
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
