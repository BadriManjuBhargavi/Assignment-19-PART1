using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
        

   public delegate int ArithmeticOperation(int num1, int num2);

    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public static void Main(string[] args)
        {
            ArithmeticOperation addDelegate = new ArithmeticOperation(Add);
            ArithmeticOperation subtractDelegate = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplyDelegate = new ArithmeticOperation(Multiply);
            ArithmeticOperation divideDelegate = new ArithmeticOperation(Divide);

            Console.WriteLine("Enter two integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int choice = int.Parse(Console.ReadLine());

            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    try
                    {
                        result = divideDelegate(num1, num2);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }

}

