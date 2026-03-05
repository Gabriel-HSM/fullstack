using Predicate.Entities;

//Representa um método que recebe um objeto do tipo T e retorna um valor boleano

//Sintaxe:
//public delegate bool Predicate<in T>(T obj);

class Program
{
    static void Main(string[] args)
    {
        
        List <Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.00));
        list.Add(new Product("HD Case", 80.00));


        // Funciona
        // list.RemoveAll(p => p.Price >= 100.0);
        // foreach (Product p in list)
        // {
        //     Console.WriteLine(p);
        // }

        list.RemoveAll(ProductTest);
        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
        
    }
    public static bool ProductTest(Product p)
    {
        return p.Price >= 100.0;
    }
}
