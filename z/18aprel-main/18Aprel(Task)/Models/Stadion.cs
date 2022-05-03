using System;
using System.Collections.Generic;
using System.Text;

namespace _18Aprel_Task_.Models
{
    internal class Stadion
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal HourPrice { get; set; }
        public int Capacity { get; set; }
        List<Stadion> Stadions { get; set; }
    }
}
