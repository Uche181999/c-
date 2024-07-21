using System;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        // Asynchronous function
        await makeTea();

        Console.ReadKey();
    }

    static async Task makeTea()
    {
        // Boil water and put tea in parallel
        var boilWaterTask = boilWater();
        var putTeaTask = putTea();
        await Task.WhenAll(boilWaterTask, putTeaTask);

        // Add your water to the cup
        await addWater();

        // Stir the tea
        await stirTea();

        // Simulate tea being ready
        await Task.Delay(3000);
        Console.WriteLine("TEA IS READY!!!!");
    }

    static async Task boilWater()
    {
        Console.WriteLine("PUT WATER ON FIRE TO BOIL");
        await Task.Delay(3000); // Simulate boiling water
        Console.WriteLine("WATER IS BOILING");
    }

    static async Task putTea()
    {
        await Task.Delay(1000); // Simulate putting tea in the cup
        Console.WriteLine("PUT YOUR TEA HERBS IN THE CUP");
    }

    static async Task addWater()
    {
        await Task.Delay(1000); // Simulate adding water
        Console.WriteLine("ADD YOUR HOT WATER TO THE CUP");
    }

    static async Task stirTea()
    {
        await Task.Delay(1000); // Simulate stirring the tea
        Console.WriteLine("STIR WITH A SPOON");
    }
}
