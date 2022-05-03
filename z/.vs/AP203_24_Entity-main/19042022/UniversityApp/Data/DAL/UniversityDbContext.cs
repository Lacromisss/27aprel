using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityApp.Data.Entities;

namespace UniversityApp.Data.DAL
{
    internal class UniversityDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BU4GQ1K\SQLEXPRESS;Database=AP203University;Trusted_Connection=TRUE");
        }
    }

}
