using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteratable
{
    class Program
    {
        public static void Main(string[] args)

        {
            ListOfAnimals farmAnimals = new ListOfAnimals();
            farmAnimals[0] = new Animal("fish","tilapia",20,30);
            farmAnimals[1] = new Animal("duck","broiler",20,70);
            farmAnimals[2] = new Animal("turkey","layer",30,80);
            foreach (Animal item in farmAnimals)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }

    }
}
