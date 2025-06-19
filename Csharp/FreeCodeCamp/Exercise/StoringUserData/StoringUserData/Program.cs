using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * string name;
             * string phone;
             * int age;
             *
             * Console.WriteLine("What is your name?");
             * name = Console.ReadLine();
             * Console.WriteLine("What is your phone number?");
             * phone = Console.ReadLine();
             * Console.WriteLine("What is your age?");
             * age = Convert.ToInt32(Console.ReadLine());
             *
             * Console.WriteLine(name);
             * Console.WriteLine(phone);
             * Console.WriteLine(age);
             */

            var name = "Gabriel";
            var phone = "0123456789";
            var age = 20;

            Console.WriteLine(name);
            Console.WriteLine(phone);
            Console.WriteLine(age);

        }
    }
}
