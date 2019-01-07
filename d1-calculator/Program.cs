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

            switch (operation)
            {
                case "add":
                    break;
                case "subtract":
                    break;
                case "multiply":
                    break;
                case "divide":
                    break;
                default:
                    break;
            }

        }

        private static double Add(double num1, double num2)
        {

        }

        private static double Subtract(double num1, double num2)
        {

        }
        private static double Multiply(double num1, double num2)
        {

        }
        private static double Divide(double num1, double num2)
        {

        }
    }
}
