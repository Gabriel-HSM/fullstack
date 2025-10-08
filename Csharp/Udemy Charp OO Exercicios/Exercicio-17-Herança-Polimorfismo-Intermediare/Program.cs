using System.Globalization;
using Exercicio_17_Herança_Polimorfismo_Intermediare.Entities;

Console.Write("Enter the number of products: ");
int nProduct = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 1; i <= nProduct; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char cui = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (cui == 'c' || cui == 'C')
    {

        products.Add(new Product(name, price));

    }
    else if (cui == 'u' || cui == 'U')
    {

        Console.Write("Manufact date (DD/MM/YYYY): ");
        DateTime manufactdate = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, manufactdate));

    }
    else if (cui == 'i' || cui == 'I')
    {

        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        products.Add(new ImportedProduct(name, price, customsFee));

    }
    else
    {
        Console.WriteLine("Invalid value");
    }

}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
