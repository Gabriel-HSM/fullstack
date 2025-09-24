using System.Globalization;
using Exercicio_Construtores_Propriedades_Sobrecarga;

int NumeroDaConta;
string Titular;
double QuantiaDeposito;
string SaldoInicial;

double ValorDeposito;
double ValorSaque;

Console.Write("Entre o número da conta: ");
NumeroDaConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
Titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
SaldoInicial = Console.ReadLine();

if (SaldoInicial == "s")
{
    Console.Write("Entre o valor de depósito inicial: ");
    QuantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("");
}
else
{
    QuantiaDeposito = 0.00;
}

ContaBancaria Conta = new ContaBancaria(NumeroDaConta, Titular, QuantiaDeposito);

Console.Write("Entre um valor para depósito: ");
ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Conta.Deposito(ValorDeposito);

Console.WriteLine("Entre um valor para saque:");
ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Conta.Saque(ValorSaque);