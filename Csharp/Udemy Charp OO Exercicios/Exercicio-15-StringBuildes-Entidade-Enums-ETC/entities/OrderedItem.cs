using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities
{
    public class OrderedItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderedItem(int quantity, double price, Product produtc)
        {
            Quantity = quantity;
            Price = price;
            Product = produtc;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}