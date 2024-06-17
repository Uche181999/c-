using System;

namespace console_input
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"welcome {name}");
            Console.ReadKey();
        }
    }
}