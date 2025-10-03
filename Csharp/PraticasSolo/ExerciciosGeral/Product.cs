using System;
using System.Globalization;

namespace ExerciciosGeral
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public Product()
        {
            if (Name == null)
            {
                Name = "Nome não cadastrado ao produto " + Id;
            }
            CreatedDate = DateTime.Now;
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return
               "Produto "
             + Id
             + " Nome "
             + Name
             + " Preco R$ "
             + Price.ToString("F2", CultureInfo.InvariantCulture)
             ;
        }
    }
}