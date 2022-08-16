using System;

namespace MaxNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Program!");
            Console.WriteLine("Find Maximum Number");


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program that want to be executed : \n 1. Find Maximum Integer \n 2. Find Maximum Float \n 3. Maximum String \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First number, Second number, Third number : ");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        int result = MaximumSolution.FindMax(first, second, third);
                        Console.WriteLine("Maximum Number is : " + result);
                        break;
                    case 2:
                        Console.WriteLine("Enter First number, Second number, Third number to check : ");
                        double firstNum = Convert.ToDouble(Console.ReadLine());
                        double secondNum = Convert.ToDouble(Console.ReadLine());
                        double thirdNum = Convert.ToDouble(Console.ReadLine());
                        double res = MaximumSolution.FindMax(firstNum, secondNum, thirdNum);
                        Console.WriteLine("The Maximum Number is : " + res);
                        break;
                    case 3:
                        Console.WriteLine("Enter Three Strings to check : ");
                        string firstName = Convert.ToString(Console.ReadLine());
                        string secondName = Convert.ToString(Console.ReadLine());
                        string thirdName = Convert.ToString(Console.ReadLine());
                        string largest = MaximumSolution.FindMax(firstName, secondName, thirdName);
                        Console.WriteLine("The Largest String is : " + largest);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }

        }
    }
}