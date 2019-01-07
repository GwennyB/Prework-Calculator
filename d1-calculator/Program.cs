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

            Console.Clear();
            Console.WriteLine("Please enter first operand:");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second operand:");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to do with them?");
            Console.WriteLine("(Enter 'add', 'subtract', 'multiply', or 'divide'.)");
            string operation = Console.ReadLine();

            double answer = 0;

            switch (operation)
            {
                case "add":
                    answer = Add(num1, num2);
                    break;
                case "subtract":
                    answer = Subtract(num1, num2);
                    break;
                case "multiply":
                    answer = Multiply(num1, num2);
                    break;
                case "divide":
                    answer = Divide(num1, num2);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"If you {operation} the numbers {num1} & {num2}, you get {answer}.");
            Console.ReadLine();

        }

        private static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        private static double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        private static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        private static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
