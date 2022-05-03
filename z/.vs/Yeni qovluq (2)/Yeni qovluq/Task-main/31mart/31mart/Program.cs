using System;

namespace _31mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                FullName = "Shukurov Mushvig"
            };
            Student student2 = new Student()
            {
                FullName = "Shukurov Ragim"
            };
            Student student3 = new Student()
            {
                FullName = "Shukurov Eyvaz"
            };
            Student student4 = new Student()
            {
                FullName = "Ragimov Onur"
            };
            Student student5 = new Student()
            {
                FullName = "Vusale Atayeva"
            };
            Student student6 = new Student()
            {
                FullName = "Ilkin Huseynov"
            };
            Group group1 = new Group(Groups.Programming)
            {
                students = new Student[2]
            };
            Group group2 = new Group(Groups.Programming)
            {
                students = new Student[2]
            };
            Group group3 = new Group(Groups.System)
            {
                students = new Student[1]
            };
            Group group4 = new Group(Groups.Design)
            {
                students = new Student[1]
            };
            group1.students[0] = student1;
            group1.students[1] = student2;
            group2.students[0] = student3;
            group2.students[1] = student4;
            group3.students[0] = student5;
            group4.students[0] = student6;
            Console.WriteLine("----*----");
            foreach (Student student in group1.students)
            {
                Console.WriteLine($"Fullname : {student.FullName} No : {student.No} Group No : {group1.No}");
            }
            Console.WriteLine("----*----");
            foreach (Student student in group2.students)
            {
                Console.WriteLine($"Fullname : {student.FullName} No : {student.No} Group No : {group2.No}");
            }
            Console.WriteLine("----*----");
            foreach (Student student in group3.students)
            {
                Console.WriteLine($"Fullname : {student.FullName} No : {student.No} Group No : {group3.No}");
            }
            Console.WriteLine("----*----");
            foreach (Student student in group4.students)
            {
                Console.WriteLine($"Fullname : {student.FullName} No : {student.No} Group No : {group4.No}");
            }

        }
    }
}
