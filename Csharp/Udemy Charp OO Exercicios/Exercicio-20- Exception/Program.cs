using System.Globalization;
using Exercicio_20__Exception.Entities;
using Exercicio_20__Exception.Entities.Excepitions;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string name = Console.ReadLine();
Console.Write("Initial balance: ");
double initialB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account account = new Account(number, name, initialB, WithdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    account.Withdraw(withdraw);

    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Widraw error: " + e.Message);
}