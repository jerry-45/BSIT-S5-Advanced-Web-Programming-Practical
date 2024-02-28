using System;

namespace TYIT2021_PRAC_1D_iv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Values in foreach loop are \n");
            foreach (int i in a)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
