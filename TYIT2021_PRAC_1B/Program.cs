using System;

namespace TYIT2021_PRAC_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "This is first string";
            string str2 = "This is second string";

            Console.WriteLine("-----STRINGS BEFORE ANY OPERATIONS-----");
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //compare operation before copy operation
            Console.WriteLine("\n-----COMPARE OPEARTION BEFORE COPY OPEARATION-----");
            Console.WriteLine(string.Compare(str1, str2));

            //copy opeartion
            str2 = string.Copy(str1);
            Console.WriteLine("\n-----STRINGS AFTER COPY OPERATION-----");
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //compare operation before copy operation
            Console.WriteLine("\n-----COMPARE OPEARTION AFTER COPY OPEARATION-----");
            Console.WriteLine(string.Compare(str1, str2));
        }
    }
}
