using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vat ou IVAé um imposto sobre as compras
            const int vat = 20;
            const double percentVAT = 20 / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);


            const string version = "v1.0";

            Console.WriteLine(vat);
        }
    }
}
