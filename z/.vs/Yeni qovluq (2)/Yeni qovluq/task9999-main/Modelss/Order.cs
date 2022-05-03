using System;
using System.Collections.Generic;
using System.Text;

namespace Modelss
{
    public class Order
    {
        public Order()
        {
            _id++;
            No = _id;

        }
        private static int _id;
        public int No { get; set; }
        List<OrderItem> OrderItems { get; set; }
        public int TotalAmount { get; set; }
        public DateTime Date { get; set; }

    }
}