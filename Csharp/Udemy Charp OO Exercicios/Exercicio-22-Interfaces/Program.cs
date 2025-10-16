using System.Globalization;

//Entrada de dados do contrato:

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
string contractNumber = Console.ReadLine();
Console.WriteLine("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());


//Saida de dados
Console.WriteLine();
