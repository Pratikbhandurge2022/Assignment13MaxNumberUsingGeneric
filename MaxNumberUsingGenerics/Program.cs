using System;

namespace MaxNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Program!");
            Console.WriteLine("Find Maximum Number");

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            MaximumNumber max = new MaximumNumber();
            int maxNumber = max.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("max number is:" + maxNumber);

        }
    }
}