using System;

namespace TYIT2021_PRAC_1D_v
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, revNum = 0, digit, sumDigits = 0;
            Console.Write("Enter a Number:");
            num = int.Parse(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                digit = num % 10;
                revNum = revNum * 10 + digit;
                sumDigits = sumDigits + digit;
                num = num / 10;
            }

            Console.WriteLine("Reverse of " + temp + " is " + revNum);
            Console.WriteLine("Sum of it's digits is " + sumDigits);
        }
    }
}
