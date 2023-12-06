using System;

namespace Addition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = AddNumbers(a, b);

            Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}