using System;
using System.Collections.Generic;
using System.Linq;
using UniversityApp.Data.DAL;
using UniversityApp.Data.Entities;

namespace UniversityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityDbContext dbContext = new UniversityDbContext();

            //Group group1 = new Group { No = "BP201", GroupLimit = 18 };
            //Group group2 = new Group { No = "BP202", GroupLimit = 12 };

            //dbContext.Groups.Add(group1);
            //dbContext.Groups.Add(group2);

            //dbContext.SaveChanges();

            //Student student1 = new Student
            //{
            //    Name = "Hikmet",
            //    Surname = "Abbasov",
            //    BirthDate = new DateTime(2002, 10, 10),
            //    GroupId = 1
            //};
            //Student student2 = new Student
            //{
            //    Name = "Nermin",
            //    Surname = "Abbasova",
            //    BirthDate = new DateTime(2002, 10, 10),
            //    GroupId = 2
            //};
            //Student student3 = new Student
            //{
            //    Name = "Tofiq",
            //    Surname = "Abbasov",
            //    BirthDate = new DateTime(2002, 10, 10),
            //    GroupId = 3
            //};
            //Student student4 = new Student
            //{
            //    Name = "Elmeddin",
            //    Surname = "Abbasov",
            //    BirthDate = new DateTime(2002, 10, 10),
            //    GroupId = 1
            //};

            //List<Student> students = new List<Student> { student1,student2, student3 , student4};
            ////dbContext.Students.Add(student1);
            ////dbContext.Students.Add(student2);
            ////dbContext.Students.Add(student3);
            ////dbContext.Students.Add(student4);

            ////dbContext.Students.AddRange(student1,student2,student3);

            //dbContext.Students.AddRange(students);

            //dbContext.SaveChanges();

            Console.WriteLine("======Find==================");
            Student student = dbContext.Students.Find(1);
            Console.WriteLine(student.Name);

            Console.WriteLine("\n======WHERE==================");

            var students = dbContext.Students.Where(x => x.GroupId == 1).OrderBy(x => x.Name).ToList();
            
           

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n======WHERE+First==================");
            var std = dbContext.Students.Where(x => x.GroupId == 1).OrderBy(x=>x.Name).FirstOrDefault();
            Console.WriteLine(std.Name);

            Console.WriteLine("\n======FirstOrDefault==================");
            std = dbContext.Students.OrderBy(x=>x.Name).FirstOrDefault(x => x.GroupId == 1);


            Console.WriteLine(std.Name);

            Console.WriteLine("\n======Remove==================");
            Group grp = dbContext.Groups.Find(4);
            grp = dbContext.Groups.FirstOrDefault(x => x.Id == 4);

            dbContext.Groups.Remove(grp);
            dbContext.SaveChanges();

        }
    }
}
