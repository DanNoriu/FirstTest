using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number from 1-3");
            
            Console.WriteLine("now!");
             int number = Convert.ToInt16(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Greetings");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Hello World");
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Hello There");
                    break;
                default:
                    Console.WriteLine("i said from 1-3");
                    break;
            }
            Console.ReadKey();
        }
    }
}
