using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 2;

            //10 / 3 = 3r1
            //3 x 3 = 9, left over to get 10

            Console.WriteLine(firstNum % secondNum);

            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 1);
        }
    }
}
