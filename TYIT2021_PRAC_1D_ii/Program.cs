using System;

namespace TYIT2021_PRAC_1D_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, i, m2 = 0, m3 = 0;
            Console.WriteLine("Enter the number to check: ");
            m1 = Int32.Parse(Console.ReadLine());
            m2 = m1 / 2;
            for (i = 2; i <= m2; i++)
            {
                if (m1 % i == 0)
                {
                    Console.WriteLine("Number is not prime.");
                    m3 = 1;
                    break;
                }
            }
            if (m3 == 0)
            {
                Console.WriteLine("Number is prime.");
            }
        }
    }
}
