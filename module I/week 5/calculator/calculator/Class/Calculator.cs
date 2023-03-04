using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Class
{
    public static class Calculator
    {
        /// <summary>
        /// Methods for the division.
        /// </summary>
        /// <returns></returns>
        public static int Division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        /// <summary>
        /// Method for the multiplication.
        /// </summary>
        /// <returns></returns>
        public static int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        /// <summary>
        /// Method for the subtraction.
        /// </summary>
        /// <returns></returns>
        public static int Subtraction(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        /// <summary>
        /// Methods for the sums.
        /// </summary>
        /// <returns></returns>
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static float Sum(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static long Sum(long firstNumber, long secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
