// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exercicio_Construtores_Propriedades_Sobrecarga
// {
//     public class DadosBancarios
//     {

//         public int NumeroDaConta;
//         public string NomeDoTitular;
//         public double Saldo;
//         public string EscolhaDeposito;
//         public static double Taxa = 5;

//         public bool DepositoInicial()
//         {
//             if (EscolhaDeposito == "s")
//             {
//                 return true;
//             }
//             else if (EscolhaDeposito == "n")
//             {
//                 return false;
//             }
//             else
//             {
//                 return false;
//             }
//         }

//         public void AbrirConta()
//         {
//             if (DepositoInicial())
//             {
//                 Console.WriteLine("Entre o valor de depósito inicial: ");
//                 Saldo = double.Parse(Console.ReadLine());
//                 Console.WriteLine("Dados da conta:");
//                 Console.WriteLine($"Conta {NumeroDaConta}, Titular: {NomeDoTitular}, Saldo: $ {Saldo}");
//             }
//             else
//             {
//                 Console.WriteLine("Dados da conta:");
//                 Console.WriteLine($"Conta {NumeroDaConta}, Titular: {NomeDoTitular}, Saldo: $ {Saldo}");
//             }
//         }

//         public void Deposito(double quantia)
//         {
//             Saldo += quantia;
//             Console.WriteLine("Dados atualizados: ");
//             Console.WriteLine("Conta " + NumeroDaConta + ", Titular " + NomeDoTitular + ", Saldo: " + Saldo);
//         }

//         public void Saque(double saque)
//         {
//             Saldo -= saque + Taxa;
//             Console.WriteLine("Dados atualizados: ");
//             Console.WriteLine("Conta " + NumeroDaConta + ", Titular " + NomeDoTitular + ", Saldo: " + Saldo);

//         }
//     }
// }