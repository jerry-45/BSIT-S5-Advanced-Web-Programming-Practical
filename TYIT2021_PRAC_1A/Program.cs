using System;

namespace TYIT2021_PRAC_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, product;

            Console.Write("Enter first number: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            num3 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            num4 = Int32.Parse(Console.ReadLine());

            product = num1 * num2 * num3 * num4;
            Console.WriteLine("Product of {0}, {1}, {2} & {3} is {4}", num1, num2, num3, num4, product);
        }
    }
}
