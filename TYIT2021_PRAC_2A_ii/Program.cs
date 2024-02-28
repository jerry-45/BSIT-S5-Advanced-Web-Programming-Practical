// 1 Euro = 88.47 INR
// 1 Dollar = 74.00 INR
// 1 Ringgit = 18.14 INR

using System;

namespace TYIT2021_PRAC_2A_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your choice: \n\t1. Dollar to Rupee \n\t2. Euro to Rupee \n\t3. Malaysian Ringgit to Rupee");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Double dollar, rupee, val1;
                    Console.WriteLine("Enter the Dollar amount: ");
                    dollar = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Dollar value: ");
                    val1 = double.Parse(Console.ReadLine());
                    rupee = dollar * val1;
                    Console.WriteLine("{0} Dollar equals {1} Rupees.", dollar, rupee);
                    break;

                case 2:
                    Double euro, rupee2, val2;
                    Console.WriteLine("Enter the Euro amount: ");
                    euro = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Euro value: ");
                    val2 = double.Parse(Console.ReadLine());
                    rupee2 = euro * val2;
                    Console.WriteLine("{0} Euro Equals {1} Rupees.", euro, rupee2);
                    break;

                case 3:
                    Double ringit, rupee3, val3;
                    Console.WriteLine("Enter the ringgit amount: ");
                    ringit = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the ringgit value: ");
                    val3 = double.Parse(Console.ReadLine());
                    rupee3 = ringit * val3;
                    Console.WriteLine("{0} Malaysian Ringgit Equals {1} Rupees.",ringit, rupee3);
                    break;

                default:
                    Console.WriteLine("Invalid Choice!!!");
                    break;
            }
        }
    }
}
