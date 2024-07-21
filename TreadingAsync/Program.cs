using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        //asyncronous function
        makeTea();



        Console.ReadKey();

    }
    static async Task makeTea()
    {
        //boil water 
        await boilWater();

        //put your tea herbs in a cup
        putTea();
        // add your water to the cup
        await addWater();
        // stair the tea 
        await stirTea();
        // tea is ready
        await Task.Delay(1000);
        Console.WriteLine("TEA IS READY!!!!");
    }
    static async Task boilWater()
    {
        Console.WriteLine("PUT WATER ON FIRE TO BOIL");
        await Task.Delay(3000);
        Console.WriteLine("WATER IS BOILING");
    }
    static void putTea()
    {
        Console.WriteLine("put ur tea herbs in the cup");

    }
    static async Task addWater()
    {
        await Task.Delay(1000);
        Console.WriteLine("add your hot water to the cup");

    }
    static async Task stirTea()
    {
        await Task.Delay(1000);
        Console.WriteLine("stair with a spoon ");

    }
}