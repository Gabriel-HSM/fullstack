using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities;
using Exercicio_15_StringBuildes_Entidade_Enums_ETC.entities.Enums;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Order order = new Order(client, status);

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product Name: ");
    string productName = Console.ReadLine();
    Console.Write("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderedItem orderItem = new OrderedItem(quantity, product.Price, product);

    order.AddItem(orderItem);

}

Console.WriteLine();
Console.WriteLine("ORDER SUMARY: ");
Console.WriteLine(order);