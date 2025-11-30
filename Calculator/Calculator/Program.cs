using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double Num1 = 0;
                double Num2 = 0;
                double Result = 0;

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Calculator Application");
                Console.WriteLine("-----------------------------");

                Console.Write("Enter Number 1!: ");
                Num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number 2!: ");
                Num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a option: ");
                Console.WriteLine("\t+    :   Addition?");
                Console.WriteLine("\t-    :   Subtraction?");
                Console.WriteLine("\t*    :   Multiplication?");
                Console.WriteLine("\t/    :   Division?");
                Console.Write("Enter your option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Result = Num1 + Num2;
                        Console.WriteLine($"Your result is: {Num1 + Num2}");
                        break;


                    case "-":
                        Result = Num1 - Num2;
                        Console.WriteLine($"Your result is: {Num1 - Num2}");
                        break;

                    case "*":
                        Result = Num1 * Num2;
                        Console.WriteLine($"Your result is: {Num1 * Num2}");
                        break;

                    case "/":
                        Result = Num1 / Num2;
                        Console.WriteLine($"Your result is: {Num1 / Num2}");
                        break;

                    default:
                        Console.WriteLine("The Following operation you put in was invalid, please put a valid operation!.");
                        break;

                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = No: ");
            }while(Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
            




            Console.ReadKey();
                }
         }
}

            