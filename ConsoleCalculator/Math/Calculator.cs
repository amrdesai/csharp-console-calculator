using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Math
{
    public class Calculator
    {
        public void RunCalculation()
        {
            // Variables
            string[] operators = new string[4] { "+", "-", "*", "/" };
            string type, restartCheck;
            int num1, num2, answer;

            // Get operator type
            Console.WriteLine("What type of calculation do you want to perform? ('+', '-', '*', '/')");
            type = GetCalcType(operators);

            // Get 1st number
            Console.WriteLine("Enter your 1st number.");
            num1 = GetCalcNum();

            // Get 2nd number
            Console.WriteLine("Enter your 2nd number.");
            num2 = GetCalcNum();

            // Run calculation
            answer = Calculate(num1, num2, type);

            // Display the answer
            Console.WriteLine($"The answer is {answer}\n Type Y[ES] to restart calculator or N[O] to exit. ");

            // Check if user wants to restart calculator
            restartCheck = Console.ReadLine().ToLower();
            if(restartCheck == "y")
            {
                Console.Clear();
                RunCalculation();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // Method: Get calculation operator type
        private string GetCalcType(string[] allowedOper)
        {
            // Get the operator
            string type = Console.ReadLine();

            // Check if valid operator is selected
            while (!allowedOper.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type --> ('+', '-', '*', '/')");
                type = Console.ReadLine();
            }

            return type;
        }


        // Method: Get number from user
        private int GetCalcNum()
        {
            int num;

            // Check if user entered a number
            bool parceCheck = Int32.TryParse(Console.ReadLine(), out num);

            // Ask for number if user entered a non mumeric value
            while (!parceCheck)
            {
                Console.WriteLine("Invalid Entry, not a number... Try again!");
                parceCheck = Int32.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }


        // Method: Calculation
        public int Calculate(int num1, int num2, string type)
        {
            // Check operator type
            if(type == "+")
            {
                return num1 + num2;
            }
            else if (type == "-")
            {
                return num1 - num2;
            }
            else if (type == "*")
            {
                return num1 * num2;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
