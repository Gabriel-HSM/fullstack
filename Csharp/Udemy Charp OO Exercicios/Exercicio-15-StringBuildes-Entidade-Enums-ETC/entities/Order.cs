using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities.Enums;

namespace Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities
{
    public class Order
    {
        private DateTime _moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderedItem> Items { get; set; } = new List<OrderedItem>();

        public Order(OrderStatus status, OrderedItem item)
        {
            _moment = DateTime.Now;
            Status = status;
            AddItem(item);
        }

        public void AddItem(OrderedItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderedItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderedItem item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
            
        }
    }
}