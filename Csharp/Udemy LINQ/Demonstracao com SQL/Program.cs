
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

        // IEnumerable<Product> r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        var r1 = 
            from p in products
            where p.Category.Tier == 1 && p.Price < 900.0
            select p;
        Print("TIER 1 AND PRICE < 900:", r1);

        //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        var r2 =
            from p in products
            where p.Category.Name == "Tools"
            select p.Name;
        Print("NAMES OF PRODUCT FROM TOOLS", r2);

        //Name no caractere 0, ou seja primeira letra
        //Ta ai o apelido do SQL, por ter nome parecido (category name foi necessário outro nome/apelido)

        //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
        var r3 = 
            from p in products
            where p.Name[0] == 'C'
            select new {p.Name, p.Price,CategorName = p.Category.Name};
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        //OrderBy ordena por uma regra
        //ThenBy depois de orderby

        //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        var r4 = 
            from p in products
            where p.Category.Tier == 1
            orderby p.Name
            orderby p.Price
            select p;
        Print("TIER 1 ORDERBY PRICE THE BY NAME", r4);

        //Pula os 2 primeiros e pega 4 elementos
        //var r5 = r4.Skip(2).Take(4);
        var r5 = 
         (from p in r4
         select p).Skip(2).Take(4);
        Print("TIER 1 ORDERBY PRICE THE BY NAME SKIP 2 TAKE 4", r5);

         //Pegar os elementos, primeiro, ultimo e etc
         //Vai gerar excessão se for apenas o first puro

        //var r6 = products.FirstOrDefault();
        //pode usar o products, mais simples
        var r6 = (from p in products select p).FirstOrDefault();
        Console.WriteLine("First  or defalt test 1: " + r6);

        //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        var r7 =
            (from p in products
            where p.Price > 3000.0
            select p).FirstOrDefault();
        Console.WriteLine("First or defalt test 2: " + r7);
        Console.WriteLine();

        //Pode controlar se eu quero uma coleção ou um simples elemento.
        //Tirando o single or defalt vira coleção (mesmo retornando só um item)
        //Se eu estiver esperando um acoleção de fato single não vai funcionar

         var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
         Console.WriteLine("Single or defalt test 1: " + r8);

         var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
         Console.WriteLine("Single or defalt test 2: " + r9);
         Console.WriteLine();

         var r10 = products.Max(p => p.Price);
         Console.WriteLine("Max Price: " + r10);

         var r11 = products.Min(p => p.Price);
         Console.WriteLine("Min Price: " + r11);

         var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
         Console.WriteLine("Category 1 sum prices: "+ r12);
        
        //Media é Average
         var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
         Console.WriteLine("Category 1 average: " + r13);
         //Proteção de media
         //DefaltIfEmpty, o proprio nome já diz
         var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
         Console.WriteLine("Category 5 average: " + r14);
         Console.WriteLine();

        //IMPORTANTE!
        //Montar uma operação agregada personalizada
        //Até então usamos apenas predefinidas
        // Se tiver um dado nullo posso passar um valor padrão
        var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("Category 1 Aggregate sum: " + r15);
        Console.WriteLine();


        //Agrupamento
        //var r16 = products.GroupBy(p => p.Category);
        var r16 = 
            from p in products
            group p by p.Category;
        foreach (IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine("Category" + group.Key.Name + ": ");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}