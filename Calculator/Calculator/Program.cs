using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "Select 1 for Add\nSelect 2 for Subtract\nSelect 3 for Multiple\nSelect 4 for Multiply";
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

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
