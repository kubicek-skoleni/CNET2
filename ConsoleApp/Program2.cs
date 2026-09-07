using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from Program2!");

            void SayHello(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }
        }
    }
}
