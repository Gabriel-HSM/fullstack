using Generics1.services;

PrintService<int> printService = new PrintService<int>();

Console.WriteLine("How many values? ");

string? imput = Console.ReadLine();
if (string.IsNullOrEmpty(imput))
{
    throw new ArgumentException("A entrada não pode ser nula");
}

int n = int.Parse(imput);


for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine("First " + printService.First());
