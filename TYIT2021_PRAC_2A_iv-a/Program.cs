using System;

namespace TYIT2021_PRAC_2A_iv_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.WriteLine("Enter fahrenheit temperature: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The temperature is " + celsius.ToString("0.00") + "C");
        }
    }
}
