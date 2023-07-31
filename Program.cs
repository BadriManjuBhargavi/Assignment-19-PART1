using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19
{


    // Step 1: Create a delegate named 'ArithmeticOperation' that represents integer parameters and a return type of 'int'.
    delegate int ArithmeticOperation(int a, int b);

    public class Program
    {
        // Step 2: Implement four static methods: 'Add', 'Subtract', 'Multiply', and 'Divide'.
        // Each method should take two integers as input and return the result of the corresponding arithmetic operation.

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public static void Main(string[] args)
        {
            // Step 3: Create instances of the 'ArithmeticOperation' delegate for each of the four arithmetic methods.
            ArithmeticOperation addDelegate = Add;
            ArithmeticOperation subtractDelegate = Subtract;
            ArithmeticOperation multiplyDelegate = Multiply;
            ArithmeticOperation divideDelegate = Divide;

            // Step 4: Ask the user to input two integers.
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Step 5: Prompt the user to choose an arithmetic operation.
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = int.Parse(Console.ReadLine());

            int result = 0;

            // Step 6: Based on the user's choice, call the corresponding method through the delegate and display the result.
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    Console.WriteLine($"Result of Addition: {result}");
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    Console.WriteLine($"Result of Subtraction: {result}");
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    Console.WriteLine($"Result of Multiplication: {result}");
                    break;
                case 4:
                    try
                    {
                        result = divideDelegate(num1, num2);
                        Console.WriteLine($"Result of Division: {result}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

    





           



