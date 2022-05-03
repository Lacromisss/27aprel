using System;
using System.Collections.Generic;
using System.Text;

namespace _06042022
{
    internal class Order
    {
        private static int _no;
        public Order()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
