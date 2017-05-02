using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CalcExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                double num1 = GetNumber();
                Console.WriteLine("Enter the second number: ");
                double num2 = GetNumber();
                Console.WriteLine("Enter the operator: ");
                string strOp = Console.ReadLine();
                switch (strOp)
                {
                    case "+":
                        Console.WriteLine("the sum of the two numbers is: " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("the difference of the two numbers is: " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("the sum of the two numbers is: " + (num1 * num2));
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine("the sum of the two numbers is: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("the second value is 0, division by 0 is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Operator. Try again!");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static double GetNumber()
        {
            double num = 0;
            while (true)
            {
                string numStr = Console.ReadLine();
                if (double.TryParse(numStr, out num))
                {
                    break;
                }
            }
            return num;
        }
    }
}