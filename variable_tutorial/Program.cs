using System;

namespace variable_tutorial
{
    public class Program
    {
        public static void main(string[] arg)
        {
            //boolean expression 
            bool called = true;
            //var select a variable by it output
            var colour = "white";
            var number = 5000;
            //string expression
            string name = "uche";
            //integer expression
            int num = 500;
            //float expression
            float dec = 5.54f;
            //double expression
            double fraction = 4.33;
            /*first method of outputing a value in writeLine*/
            Console.WriteLine($"the value of called as a boolean expression :{called} ");
            /*second method of outputing a value in writeLine*/
            Console.WriteLine("the value of number as a integer expression :{0} ", number);
            //my favourite method of outputing value
            Console.WriteLine($"the value of colour as a string expression :{colour} ");
            Console.WriteLine($"the value of name as a string expression :{name} ");
            Console.WriteLine($"the value of num as a integer expression :{num} ");
            Console.WriteLine($"the value of dec as a float expression :{dec} ");
            Console.WriteLine($"the value of fraction as a double expression :{fraction} ");


        }
    }


}
