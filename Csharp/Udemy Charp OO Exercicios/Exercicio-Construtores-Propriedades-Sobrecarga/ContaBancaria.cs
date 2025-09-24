using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Construtores_Propriedades_Sobrecarga
{
    public class ContaBancaria
    {

        private int Numero;
        private string Titular;
        private double Saldo;

        public ContaBancaria(int numeroconta, string titular)
        {
            if (Numero == 0)
            {
                Numero = numeroconta;
            }

            Titular = titular;

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta " + numeroconta + ", Titular " + Titular + ", Saldo " + Saldo);
        }

        public ContaBancaria(int numeroconta, string titular, double saldo) : this(numeroconta, titular)
        {
            Saldo = saldo;
        }
        
        

        public void Deposito()
        {
            Console.WriteLine(Numero);
        }
        // public void Saque(){}
    }
}