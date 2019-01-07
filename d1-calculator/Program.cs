using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreCalcs = true;
            while (moreCalcs)
            {
                moreCalcs = Manager();
            }

        }

        static bool Manager()
        {
            // get inputs from user
            Console.Clear();
            Console.WriteLine("Please enter first operand:");
            double num1 = Double.Parse(Console.ReadLine()); // parse input to double and save to new variable 'num1'
            Console.WriteLine("Please enter second operand:");
            double num2 = Double.Parse(Console.ReadLine()); // parse input to double and save to new variable 'num2'
            Console.WriteLine("What would you like to do with them?");
            Console.WriteLine("(Enter 'add', 'subtract', 'multiply', or 'divide'.)");
            string operation = Console.ReadLine(); // save input to new variable 'operation'

            // set answer variable
            double answer = 0;

            // route to appropriate operation function
            switch (operation)
            {
                case "add": // Route to Add function
                    answer = Add(num1, num2);
                    Console.WriteLine($"The sum of {num1} & {num2} is {answer}.");
                    break;
                case "subtract": // Route to Subtract function
                    answer = Subtract(num1, num2);
                    Console.WriteLine($"The difference of {num1} & {num2} is {answer}.");
                    break;
                case "multiply": // Route to Multiply function
                    answer = Multiply(num1, num2);
                    Console.WriteLine($"The product of {num1} & {num2} is {answer}.");
                    break;
                case "divide": // Route to Divide function
                    answer = Divide(num1, num2);
                    Console.WriteLine($"The quotient of {num1} & {num2} is {answer}.");
                    break;
                default:
                    break;
            }

            Console.ReadLine(); // keep console open until user exits
            return true;

        }

        // operation functions - pass in both operands to selected operation, return answer for display

        // add function
        private static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        // subtract function
        private static double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        // multiply function
        private static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        // divide function
        private static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
