
using Demonstracao.Entities;
using Predicate.Entities;

class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

        List<Product> products = new List<Product>()
        {
            new Product(1, "Computer", 1100.0, c2),
            new Product(2, "Hammer", 90.0, c1),
            new Product(3, "TV", 1700.0, c3),
            new Product(4, "Notebook", 1300.0, c2),
            new Product(5, "Saw", 80.0, c1),
            new Product(6, "Tablet", 700.0, c2),
            new Product(7, "Camera", 700.0, c3),
            new Product(8, "Printer", 350.0, c3),
            new Product(9, "MacBook", 1800.0, c2),
            new Product(10, "Sound Bar", 700.0, c3),
            new Product(11, "Level", 70.0, c1)
        };

        IEnumerable<Product> results1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

        Print("TIER 1 AND PRICE < 900:", results1);

        var results2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCT FROM TOOLS", results2);

        //Name no caractere 0, ou seja primeira letra
        //Ta ai o apelido do SQL, por ter nome parecido (category name foi necessário outro nome/apelido)
        var result3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", result3);
    }
}