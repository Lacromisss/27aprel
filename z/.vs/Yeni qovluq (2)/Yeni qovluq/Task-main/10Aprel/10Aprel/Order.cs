using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    public class Order
    {
        public static int _no;
        public Order()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; }
    }
}

