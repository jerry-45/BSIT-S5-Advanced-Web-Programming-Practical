using System;

namespace TYIT2021_PRAC_2A_iii
{
    class Program
    {

        void findRoots(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.Write("Invalid!!!");
                return;
            }

            int d = b * b - 4 * a * c;
            Double sqrt_val = Math.Abs(d);
            if (d > 0)
            {
                Console.WriteLine("The roots are real and different.\n");
                Console.Write((Double)(-b + sqrt_val) / (2 * a) + "\n" + (Double)(-b - sqrt_val) / (2 * a));
            }
            else
            {
                Console.WriteLine("Roots are complex.\n");
                Console.Write(-(Double)b / (2 * a) + "+i" + sqrt_val + "\n" + -(Double)b / (2 * a) + "-i" + sqrt_val);
            }
        }

        static void Main(string[] args)
        {
            Program rt = new Program();
            int a = 1, b = -7, c = 12;
            rt.findRoots(a, b, c);
        }
    }
}
