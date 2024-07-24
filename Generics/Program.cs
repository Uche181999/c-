using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(area(20, 25));
            Console.ReadKey();

        }
        static double area<T>(T length, T breadth)
        {
            double len;
            double bread;

            if (length == null || length.GetType() == typeof(string))
            {
                len = 1;
            }
            if (breadth == null || breadth.GetType() == typeof(string) || length == null)
            {
                bread = 1;
            }
            len = Convert.ToDouble(length);
            bread = Convert.ToDouble(breadth);

            return len * bread;
        }
    }

}

