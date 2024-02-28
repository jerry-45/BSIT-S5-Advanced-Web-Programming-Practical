using System;

namespace TYIT2021_PRAC_1D_iii
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Console.WriteLine("Enter your choice:");
            choice = (char)Console.Read();
            switch (choice)
            {
                case 'a':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'A':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'e':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'E':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'i':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'I':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'o':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'O':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'u':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                case 'U':
                    Console.WriteLine(choice + " is vowel.");
                    break;
                default:
                    Console.WriteLine(choice + " is not a vowel.");
                    break;
            }
        }
    }
}
