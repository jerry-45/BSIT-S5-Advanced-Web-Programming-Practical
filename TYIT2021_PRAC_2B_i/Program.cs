using System;

namespace TYIT2021_PRAC_2B_i
{
    class Program
    {

        public void swap(ref int n, ref int m)
        {
            int t;
            t = n;
            n = m;
            m = t;
        }

        public void swap(ref float f1, ref float f2)
        {
            float f;
            f = f1;
            f1 = f2;
            f2 = f;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            int n = 10, m = 20;
            Console.WriteLine("Before Swap: " + "\tN = " + n + "\tM = " + m);
            p1.swap(ref n, ref m);
            Console.WriteLine("After Swap: " + "\tN = " + n + "\tM = " + m);

            float f1 = 10.5f, f2 = 20.6f;
            Console.WriteLine("Before Swap " + "\tN=" + f1 + "\tM=" + f2);
            p1.swap(ref f1, ref f2);
            Console.WriteLine("After Swap " + "\tN=" + f1 + "\tM=" + f2);
        }
    }
}
