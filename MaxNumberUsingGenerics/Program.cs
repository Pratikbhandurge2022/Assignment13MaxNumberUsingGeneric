using System;

namespace MaxNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Program!");
            Console.WriteLine("Find Maximum Number");

            //Maximum Number For all 3 int , Float , Character
            String num1 = "1.2";
            String num2 = "2.2";
            String num3 = "3.2";

            String max = FindMaximum<String>.maximum(num1, num2, num3);
            Console.WriteLine("Maximum number is :" + max);



        }
    }
}