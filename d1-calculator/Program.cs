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
            while (true)
            {
                Manager();
            }
        }

        static void Manager()
        {
            // get inputs from user
            Console.Clear();
            double answer = 0;
            double num1 = 0;
            double num2 = 0; ;
            Console.WriteLine("(Enter 'add', 'subtract', 'multiply', 'divide', or 'exit'.)");
            string operation = ValidateOperation(Console.ReadLine()); // save input to new variable 'operation'
            if (operation != "exit")
            {
                Console.WriteLine("Please enter first operand:");
                num1 = ValidateNum(Console.ReadLine()); // collect input, validate, save to new variable 'num1'
                Console.WriteLine("Please enter second operand:");
                num2 = ValidateNum(Console.ReadLine()); // collect input, validate, save to new variable 'num1'

                // set answer variable
            }

            // route to appropriate operation function
            switch (operation)
            {
                case "add": // Route to Add function
                    answer = Add(num1, num2);
                    Console.WriteLine($"The sum of {num1} & {num2} is {answer}. (Press 'enter' to continue.)");
                    break;
                case "subtract": // Route to Subtract function
                    answer = Subtract(num1, num2);
                    Console.WriteLine($"The difference of {num1} & {num2} is {answer}. (Press 'enter' to continue.)");
                    break;
                case "multiply": // Route to Multiply function
                    answer = Multiply(num1, num2);
                    Console.WriteLine($"The product of {num1} & {num2} is {answer}. (Press 'enter' to continue.)");
                    break;

                case "divide": // Route to Divide function
                    if (num2 == 0)
                    {
                        Console.WriteLine("Can't divide by 0.");
                    }
                    else
                    {
                        answer = Divide(num1, num2);
                        Console.WriteLine($"The quotient of {num1} & {num2} is {answer}. (Press 'enter' to continue.)");
                    }
                    break;
                default:
                    break;
            }

            Console.ReadLine(); // keep console open until user exits

        }

        // validate user's inputs
        private static double ValidateNum(string input) // numeric inputs
        {
            double validInput = 0;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    validInput = Double.Parse(input); // parse input to double and save to new variable 'num1'
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    input = Console.ReadLine();
                }
            }
            return validInput;
        }

        private static string ValidateOperation(string input) // numeric inputs
        {
            while (input != "add" && input != "subtract" && input != "multiply" && input != "divide" && input != "exit")
            {
                Console.WriteLine("Invalid input. Try again.");
                input = Console.ReadLine();
            }
            if(input == "exit")
            {
                System.Environment.Exit(0);
            }
            return input;
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
