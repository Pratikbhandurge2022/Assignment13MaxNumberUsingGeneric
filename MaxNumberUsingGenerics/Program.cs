using System;

namespace MaxNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Program!");
            Console.WriteLine("Find Maximum Number");

            int[] intArray = new int[] { 2, 1, 3, 1, 5, 7 };
            GenericMaximum<int> genInt = new GenericMaximum<int>(intArray);
            genInt.PrintMaxValue();

            char[] charArray = new char[] { 'w', 'j', 'k', 'z' };
            GenericMaximum<char> genChar = new GenericMaximum<char>(charArray);
            genChar.PrintMaxValue();

            double[] doubleArray = new double[] { 23.4, 5.5, 12.1, 34.2, 12.8 };
            GenericMaximum<double> genDouble = new GenericMaximum<double>(doubleArray);
            genDouble.PrintMaxValue();


        }
    }
}