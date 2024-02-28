using System;

namespace TYIT2021_PRAC_1D_i
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 1, m1, i, num;
            Console.Write("Upto how many numbers you want fibonacci series: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Element 0 is " + m);
            Console.WriteLine("Element 1 is " + n);
            for (i = 2; i < num; i++)
            {
                m1 = m + n;
                Console.WriteLine("Element " + i + " is " + m1);
                m = n;
                n = m1;
            }
        }
    }
}
