using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            // + - * /
            age += 10;
            Console.WriteLine(age);
            age = 23;

            age *= 10;
            Console.WriteLine(age);
            age = 23;

            age /= 10;
            Console.WriteLine(age);


            string name = "aba";
            name += " is programing";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);
        }
    }
}
