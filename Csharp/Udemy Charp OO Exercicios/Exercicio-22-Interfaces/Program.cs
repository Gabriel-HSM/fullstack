
using Exercicio_22_Interfaces.Entities;
using Exercicio_22_Interfaces.Services;

Console.WriteLine("Enter contract data: ");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("COntract vlaue: ");
double contractTotalValue = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number of installments: ");
int contractInstallments = int.Parse(Console.ReadLine());

Contracts myContract = new Contracts(contractNumber, contractDate, contractTotalValue);

PaymentService paymentService = new PaymentService(new PaypalService());
paymentService.ProcessPayment(myContract, contractInstallments);

Console.WriteLine("Installments:");
foreach (Installment installmentsOBJ in myContract.Installments)
{
    Console.WriteLine(installmentsOBJ);
}