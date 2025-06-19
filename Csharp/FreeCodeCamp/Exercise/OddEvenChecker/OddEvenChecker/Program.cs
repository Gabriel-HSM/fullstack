using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * int numberOne = 80,
             * int numberTwo = 50;
             * int rest = numberOne % numberTwo;
             * Console.WriteLine(rest);
             *
             * numberOne = 25;
             * rest = numberOne % numberTwo;
             * Console.WriteLine(rest);
             */

            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);
        }
    }
}
