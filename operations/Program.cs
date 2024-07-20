using System;
namespace operations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //it include conditions
            //arithmetic operation( +, -,* , /)
            //logical operation ( <, >, <= ,>=, ==) they returna boolean expression true or false
            int a = 10;
            int b = 10;
            /* if (!(a > b))
             {
                 Console.WriteLine("a is bigger than b");
             }
             else Console.WriteLine("a is less than b");*/


            //ternary operation
            var value = a == b ? "a is equal to b" : a > b ? "a is greater than b" : "b is greater than a";
            Console.WriteLine(value);




            Console.ReadKey();
        }
    }
}