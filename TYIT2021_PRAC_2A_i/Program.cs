using System;

namespace TYIT2021_PRAC_2A_i
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num1;
            Console.WriteLine("Enter the number:");
            num1 = int.Parse(Console.ReadLine());
            for (i = 1; i <= num1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number " + num1 + " is "+ fact);
        }
    }
}
