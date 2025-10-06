using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosGeral
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        private List<OrderedItem> _orders { get; set; }

        public Order(int id)
        {
            Id = id;
            DateOrder = DateTime.Now;
            _orders = new List<OrderedItem>();
        }

        public void AddOrder(OrderedItem order)
        {
            _orders.Add(order);
        }

        public void RemoveOrder(OrderedItem order)
        {
            _orders.Remove(order);
        }

        public double CalcTotal()
        {
            double subtotal = 0;
            foreach (OrderedItem i in _orders)
            {
                subtotal += i.Subtotal;
            }
            return subtotal;
        }
    }
}