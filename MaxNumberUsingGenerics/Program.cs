using System;

namespace MaxNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Program!");
            Console.WriteLine("Find Maximum Number");


            float num1 = 1.2f;
            float num2 = 2.2f;
            float num3 = 3.2f;
            //Max Float Number
            FloatNumber floatNumber = new FloatNumber();
            float max = floatNumber.FindMaximum(num1, num2, num3);
            Console.WriteLine("Maximum number is :" + max);

        }
    }
}