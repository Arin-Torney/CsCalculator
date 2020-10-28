using System;

namespace CsCalculator
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
            Console.WriteLine("Valid operations :");
            Console.WriteLine("Add - For addition");
            Console.WriteLine("Subtract - For subtraction");
            Console.WriteLine("Divide - For division");
            Console.WriteLine("Multiply - For mutiplication");
            Console.WriteLine("Mod - For finding remainder");
            Console.WriteLine("Hypot - For finding Hypotenuse");
            Console.WriteLine("Diff - For finding difference\n");
            while (forExit != "exit")
            {
                Console.Write("Enter a number : ");
                Num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter an operation : ");
                op = Console.ReadLine();
                Console.Write("Enter another number : ");
                Num2 = Convert.ToDouble(Console.ReadLine());
                if (op == "Add")
                {
                    result = Num1 + Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Subtract")
                {
                    result = Num1 - Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Multiply")
                {
                    result = Num1 * Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Divide")
                {
                    result = Num1 / Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Mod")
                {
                    result = Num1 % Num2;
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Hypot")
                {
                    result = Math.Sqrt(Num1 * Num1 + Num2 * Num2);
                    Console.WriteLine("\nThe result is " + result + ".");
                }
                else if (op == "Diff")
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
