using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberUsingGenerics
{
    public class MaximumSolution
    {
        public static int FindMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        public static double FindMax(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        public static string FindMax(string firstWord, string secondWord, string thirdWord)
        {
            if (firstWord.Length > secondWord.Length && firstWord.Length > thirdWord.Length)
            {
                return firstWord;
            }
            if (secondWord.Length > firstWord.Length && secondWord.Length > thirdWord.Length)
            {
                return secondWord;
            }
            else
            {
                return thirdWord;
            }
        }

    }
}