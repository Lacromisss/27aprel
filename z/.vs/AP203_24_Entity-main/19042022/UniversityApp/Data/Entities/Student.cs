using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp.Data.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
