using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        //syncronous function
        makeTea();



        Console.ReadKey();

    }
    static void makeTea()
    {
        //boil water 
        boilWater();

        //put your tea herbs in a cup
        putTea();
        // add your water to the cup
        addWater();
        // stair the tea 
        stirTea();
        // tea is ready
        Thread.Sleep(3000);
        Console.WriteLine("TEA IS READY!!!!");
    }
    static void boilWater()
    {
        Console.WriteLine("PUT WATER ON FIRE TO BOIL");
        Thread.Sleep(1000);
        Console.WriteLine("WATER IS BOILING");
    }
    static void putTea()
    {
        Thread.Sleep(1000);
        Console.WriteLine("put ur tea herbs in the cup");

    }
    static void addWater()
    {
        Thread.Sleep(1000);
        Console.WriteLine("add your hot water to the cup");

    }
    static void stirTea()
    {
        Thread.Sleep(1000);
        Console.WriteLine("stair with a spoon ");

    }
}
