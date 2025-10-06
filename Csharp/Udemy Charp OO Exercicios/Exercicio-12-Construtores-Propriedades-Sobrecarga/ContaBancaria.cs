using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Construtores_Propriedades_Sobrecarga
{
    public class ContaBancaria
    {

        private int Numero;
        private string Titular;
        private double Saldo;


        public ContaBancaria(int numeroconta, string titular, double saldo)
        {
            if (Numero == 0)
            {
                Numero = numeroconta;
            }

            Saldo = saldo;
            Titular = titular;

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta " + numeroconta + ", Titular " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");
        }



        public void Deposito(double quantia)
        {
            Saldo += quantia;
            Console.WriteLine("Dados da conta atulizados:");
            Console.WriteLine("Conta " + Numero + ", Titular " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");
            
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;    
            Console.WriteLine("Dados da conta atulizados:");
            Console.WriteLine("Conta " + Numero + ", Titular " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}