using System.Runtime.ConstrainedExecution;
using Predicate.Entities;
//Representa um método que recebe zero ou mais argumentos e retorna um valor
//16 sobrecargas
//Sintaxe

// public delegate TResult Func<out TResult>();
// public delegate TResult Func<in T, out TResult>(T obj);
// public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

class Program
{
    static void Main(string[] args)
        {
            
            List <Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.00));

            // Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper();
            
            //select pega uma coleção e transforma em outra
            // List<string> result = list.Select(NameUpper).ToList();
            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

}