using System;

namespace Calculator
{
    class Program
    {
        static void exit()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            string op;
            string forExit = "";
            double result;
            Console.WriteLine("Valid operations :\nAddition\nSubtraction\nDivision\nMultiplication\nModulus\nHypotenuse\nDifference\n");
            while(forExit != "exit")
            {
                Console.Write("Enter a number : ");
                Num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter an operation : ");
                op = Console.ReadLine();
                Console.Write("Enter another number : ");
                Num2 = Convert.ToDouble(Console.ReadLine());
                if (op == "Addition")
                {
                    result = Num1 + Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Subtraction")
                {
                    result = Num1 - Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Multiplication")
                {
                    result = Num1 * Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Division")
                {
                    result = Num1 / Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Modulus")
                {
                    result = Num1 % Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Hypotenuse")
                {
                    result = Math.Sqrt(Num1 * Num1 + Num2 * Num2);
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Difference")
                {
                    result = Math.Abs(Num1 - Num2);
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else
                {
                    Console.WriteLine("\nWrong input! Please try again!");
                }
                Console.WriteLine("\nLeave this empty if you don't want to exit.");
                Console.WriteLine("Enter 'exit' if you want to exit");
                Console.Write("cmd> ");
                forExit = Console.ReadLine();
            }

            exit();
        }
    }
}
