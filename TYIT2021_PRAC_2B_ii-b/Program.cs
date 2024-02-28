using System;

namespace TYIT2021_PRAC_2B_ii_b
{
    class test
    {
        public void show()
        {
            Console.WriteLine("Show of level 1");
        }
    }

    class testme : test
    {
        public void showme()
        {
            base.show();
            Console.WriteLine("Show of level 2");
        }
    }

    class Testus : testme 
    {
        public void showus()
        {
            base.showme();
            Console.WriteLine("Show of level 3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Testus t1 = new Testus();
            t1.showus();
        }
    }
}
