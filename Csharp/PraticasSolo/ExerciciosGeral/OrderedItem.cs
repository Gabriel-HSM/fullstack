using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosGeral
{
    public class OrderedItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Subtotal { get; set; }

        public OrderedItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.UnitPrice = product.Price;
            this.Subtotal = quantity * product.Price;
        }

    }
}