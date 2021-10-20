using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            string num1 = "";
            string num2 = "";
            string operationSelected = "";
            double result = 0;

            double cleanNum1 = 0;
            while(!double.TryParse(num1, out cleanNum1))
            {
                Console.WriteLine("Please enter the first number:");
                num1 = Console.ReadLine();
            }

            double cleanNum2 = 0;
            while (!double.TryParse(num2, out cleanNum2))
            {
                Console.WriteLine("Please enter the second number:");
                num2 = Console.ReadLine();
            }

            Console.WriteLine("Please choose a operand from the following list");
            Console.WriteLine("a - add");
            Console.WriteLine("s - substract");
            Console.WriteLine("m - multiply");
            Console.WriteLine("d - divide");

            while (!(operationSelected == "a" || operationSelected == "s" || operationSelected == "d" || operationSelected == "m"))
            {
                Console.WriteLine("Please choose a valid operation");
                operationSelected = Console.ReadLine();
            }

            try
            {
                result = Calculator.PerformOperation(cleanNum1, cleanNum2, operationSelected);
                if (double.IsNaN(result))
                {
                    throw (new Exception());
                } else
                {
                    Console.WriteLine($"The result of the operation is: {result}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error occurred during calculation");
                Console.WriteLine($"Details - {e.Message}");
            }
        }
    }
}
