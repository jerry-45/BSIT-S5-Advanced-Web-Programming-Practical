using System;

namespace TYIT2021_PRAC_2B_ii_a
{
    public class base1
    {
        protected int a = 50;
        protected int b = 60;
    }

    public class base2 : base1
    {
        public void show()
        {
            int c;
            c = a + b;
            Console.WriteLine("Example of Single Inheritance with protected mode" + "\n\nSum is " + c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            base2 c2 = new base2();
            c2.show();
        }
    }
}
