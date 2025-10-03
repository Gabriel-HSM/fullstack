using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosGeral
{
    public class ProductCatalog
    {
        public List<Product> ProductList { get; set; }

        public ProductCatalog()
        {
            ProductList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }

        public void ShowCatalog()
        {
            foreach (Product obj in ProductList)
            {
            TimeSpan createdTime = DateTime.Now - obj.CreatedDate;
            Console.WriteLine($"{obj} Tempo criado em dias: {createdTime.Days} Horas: {createdTime.Hours} Minutos: {createdTime.Minutes} Segundos: {createdTime.Seconds} e milisegundo {createdTime.Milliseconds}");
            }
        }
    }
}