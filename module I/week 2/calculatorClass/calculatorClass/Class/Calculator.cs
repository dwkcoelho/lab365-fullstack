using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorClass.Class
{
    public class Calculator
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public int Subtraction(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int Division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
