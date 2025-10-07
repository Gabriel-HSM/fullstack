using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities.Enums;

namespace Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities
{
    public class Order
    {
        private DateTime _moment { get; set; }
        private Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderedItem> Items { get; set; } = new List<OrderedItem>();


        public Order(Client client, OrderStatus status)
        {
            _moment = DateTime.Now;
            Client = client;
            Status = status;
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
                total += item.SubTotal();
            }
            return total;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {_moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items:");
            foreach (OrderedItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }


            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}