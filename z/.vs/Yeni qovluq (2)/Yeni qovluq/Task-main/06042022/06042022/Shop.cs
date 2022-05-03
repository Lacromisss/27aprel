using System;
using System.Collections.Generic;
using System.Text;

namespace _06042022
{
    internal class Shop
    {
        List<Order> _orders;
        public Shop()
        {
            _orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            if(_orders.Count != 0)
            {
                double sum = 0;
                foreach (var order in _orders)
                {
                    sum += order.TotalAmount;
                }
                return sum / _orders.Count;
            }
            return 0;
            

        }
        public double GetOrdersAvg(DateTime time)
        {
            var orders = _orders.FindAll(order => order.CreatedAt > time);
            double sum = 0;
            foreach (var order in orders)
            {
                sum += order.TotalAmount;
            }
            return sum / orders.Count;
        }
        public void RemoveOrderByNo(int? no)
        {
            if (no == null)
                throw new Exception("no == null");
            var order = _orders.Find(order => order.No == no);
            if(order!=null)
                _orders.Remove(order);  
        }
        public List<Order> FilterOrderByPrice(double maxPrice,double minPrice)
        {
            return _orders.FindAll(order => order.TotalAmount > minPrice && order.TotalAmount < maxPrice);
        }
    }
}
