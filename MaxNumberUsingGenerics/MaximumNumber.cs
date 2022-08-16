using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberUsingGenerics
{
    internal class MaximumNumber
    {
        public int ReturnMaxNumber(int num1, int num2, int num3)
        {
            int temp;
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }

            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;

                return num1;
            }

            else
            {
                temp = num1;
                num1 = num3;
                num3 = temp;

                return num1;
            }
        }
    }
}