using Exercicio_Construtores_Propriedades_Sobrecarga;

int NumeroDaConta;
string Titular;
double QuantiaDeposito;
string SaldoInicial;

Console.Write("Entre o número da conta: ");
NumeroDaConta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
Titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
SaldoInicial = Console.ReadLine();

if (SaldoInicial == "s")
{
    Console.Write("Entre o valor de depósito inicial: ");
    QuantiaDeposito = double.Parse(Console.ReadLine());

    ContaBancaria Conta = new ContaBancaria(NumeroDaConta, Titular, QuantiaDeposito);
}
else
{
    ContaBancaria Conta = new ContaBancaria(NumeroDaConta, Titular);
}














// DadosBancarios dados = new DadosBancarios();
// double QuantiaDeposito;
// double QuantiaSaque;

// Console.Write("Entre o número da conta: ");
// dados.NumeroDaConta = int.Parse(Console.ReadLine());
// Console.Write("Entre o titular da conta: ");
// dados.NomeDoTitular = Console.ReadLine();
// Console.Write("Haverá depósito inicial (s/n)? ");
// dados.EscolhaDeposito = Console.ReadLine();

// dados.AbrirConta();

// Console.Write("Entre um valor para depósito: ");
// QuantiaDeposito = double.Parse(Console.ReadLine());
// dados.Deposito(QuantiaDeposito);

// Console.Write("Entre um valor para saque: ");
// QuantiaSaque = double.Parse(Console.ReadLine());
// dados.Saque(QuantiaSaque);