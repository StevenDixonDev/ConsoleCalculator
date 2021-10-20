using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Calculator
    {
        /*
         * A Basic calculator needs to be able to provide functionality for 
         * Addition
         * Multiplication
         * Division
         * Subtraction
         * 
        */

        static double Add(double operatorOne, double operatorTwo)
        {
            return operatorOne + operatorTwo;
        }

        static double Subtract (double operatorOne, double operatorTwo)
        { 
            return operatorOne - operatorTwo;
        }

        static double Divide (double operand, double op)
        {
            if (op == 0)
            {
                return double.NaN;
            } else
            {
                return operand / op;
            }
        }

        static double Multiply(double op, double operand)
        {
            return op * operand;
        }
        public static double PerformOperation(double num1, double num2, string operation)
        {
            double result = double.NaN;

            switch (operation)
            {
                case "a": 
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
