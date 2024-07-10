using System;

namespace Iteratable
{
    class Animal
    {
        public static int count = 0;
        public string Name { get; set; }

        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public static void countAnimal()
        {
            Console.WriteLine("number of animals : {0}", count);

        }
        public Animal(string name = "no name", string type = "no type", int age = 0, double weight = 0)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
            count++;


        }
        public Animal()
        {
            Name = "no name";
            Type = "no type";
            Age = 0;
            Weight = 0;

        }
    }
}
