using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            */

            Console.WriteLine("What do you want repeat?: ");
            string message = Console.ReadLine();
            Console.WriteLine("And how many times do you want to repeat it?:");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)//teste caso o usuário digite número menor ou igual a 0
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)  //i = i+ 1 | i+=1
                {
                    Console.WriteLine(message);
                }
            }

               
           
            /*
            for (int i = 0; i <= 10; i += 2) //pares
            {
                Console.WriteLine(i);
            }
            
            for (int i = 1; i <= 10; i += 2) //impares
            {
                Console.WriteLine(i);
            }
            */
        }
    }
}
