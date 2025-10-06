using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities
{
    public class OrderedItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public OrderedItem(int quantity, double price, Product produtc)
        {
            Quantity = quantity;
            Price = price;
            Products.Add(produtc);
        }

        public double SubTotal()
        {
            double subTotal = 0;
            foreach (Product product in Products)
            {
                subTotal += product.Price * Quantity;

            }
            return subTotal;
        }

    }
}