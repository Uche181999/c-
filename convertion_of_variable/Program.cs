using System;
namespace convertion_of_variable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //conerting string to other variable using {variable type}.Parse({string value})
            string strNum = "12.435";
            var dblNum = double.Parse(strNum);
            Console.WriteLine($"data type : {dblNum.GetType()}");
            Console.WriteLine($"data type : {strNum.GetType()}");
            //conerting other variable to string using {variable name}.ToString()
            bool itIsComing = true;
            var strItIsComing = itIsComing.ToString();
            Console.WriteLine($"data type : {itIsComing.GetType()}");
            Console.WriteLine($"data type : {strItIsComing.GetType()}");
            //convertion between numbers
            //implicit (lossing of data e.g like a convertion between double to integer where there is a loss of decimal places)
            double secDbl = 2.2423;
            var intEx = (int)secDbl;
            Console.WriteLine($"data type : {secDbl.GetType()}");
            Console.WriteLine($"data type : {intEx.GetType()}");
            //explicit converting small variable datatypr to bigger once
            int secInt = 32546;
            long newInt = secInt;
            Console.WriteLine($"data type : {secInt.GetType()}");
            Console.WriteLine($"data type : {newInt.GetType()}");

            Console.ReadKey();
        }
    }
}