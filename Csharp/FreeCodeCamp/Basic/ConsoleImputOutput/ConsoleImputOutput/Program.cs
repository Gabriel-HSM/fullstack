using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello! My name is Gabriel!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            //string ageImput = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine(age);

            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write(" your age is ");
            //Console.Write(age);
            Console.WriteLine();
            Console.WriteLine("Your name is " + name + "and your age is " + age);
            }
    }
}
