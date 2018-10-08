using System;

namespace Calculator
{
    //Simple calculator program that does not perform error handling for non-integer inputs
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "Select 1 for Add\nSelect 2 for Subtract\nSelect 3 for Multiply\nSelect 4 for Divide";
            int[] userInput = new int[3];
            
            //Print Menu
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("{0}", menu);

            //Get User
            userInput[0] = Convert.ToInt32(Console.ReadLine());

            //Get User input (operands)
            Console.WriteLine("Enter in two operands (hit enter after each):");
            for (int i = 1; i < 3; i++)
            {
                userInput[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Return Output
            GetResult(userInput[0], userInput[1], userInput[2]);
        }

        //Add method
        static int Add(int x, int y)
        {
            return x + y;
        }

        //Subtract method
        static int Subtract(int x, int y)
        {
            return x - y;
        }

        //Multiplication method
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        //Division method
        static float Divide(int x, int y)
        {
            float result = x / (float)y;
            return result;
        }

        //GetResult method. Runs the selected operation with the given operands
        static void GetResult(int choice, int x, int y)
        {
            switch (choice)
            {
                //Addition
                case 1:
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                //Subtraction
                case 2:
                    Console.WriteLine($"{x} - {y} = {Subtract(x, y)}");
                    break;
                //Multiplication
                case 3:
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                //Division
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Cannot Divide by zero. Goodbye.");
                        break;
                    }
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;
                //Operation Unrecognized
                default:
                    Console.WriteLine("Selected operation not recognized. Goodbye.");
                    return;
            }
        }
    }
}
