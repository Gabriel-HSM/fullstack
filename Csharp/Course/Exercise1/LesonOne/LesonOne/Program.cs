using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesonOne
{
    internal class Program
    {
        static void Main(string[] args){
            string[] peca1 = Console.ReadLine().Split(' ');

            int cod1 = Convert.ToInt32(peca1[0]);
            int num1 = Convert.ToInt32(peca1[1]);
            double valor1 = Convert.ToDouble(peca1[2]);

            string[] peca2 = Console.ReadLine().Split(' ');

            int cod2 = Convert.ToInt32(peca2[0]);
            int num2 = Convert.ToInt32(peca2[1]);
            double valor2 = Convert.ToDouble(peca2[2]);

            double total = valor1 * num1 + valor2 * num2;
            Console.WriteLine("VALORA PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
