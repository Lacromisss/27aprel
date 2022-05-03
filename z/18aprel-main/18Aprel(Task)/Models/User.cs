using System;
using System.Collections.Generic;
using System.Text;

namespace _18Aprel_Task_.Models
{
    internal class User
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public string Email { get; set; }
        List<User> Users { get; set; }
    }
}
