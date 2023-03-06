using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberValidator.Class
{
    public static class NumberValidator
    {
        /// <summary>
        /// Methods to know if it is a prime number.
        /// </summary>
        /// <returns></returns>
        public static bool IsPrimeNumber(int firstNumber)
        {
            int count = 1;

            for (int j = 1; j < firstNumber; j++)
            {
                if (firstNumber % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Methods to know if it is a prime number.
        /// </summary>
        /// <returns></returns>
        public static string EvenOddNumber(int number) 
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        /// <summary>
        /// Methods to know if a number is divisible.
        /// </summary>
        /// <returns></returns>
        public static bool IsItDivisible(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber == 0 ? true : false;
        }

    }
}
