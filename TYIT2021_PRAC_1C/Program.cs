using System;

namespace TYIT2021_PRAC_1C
{
    class Program
    {

        struct student
        {
            public string studentID, studentName, courseName;
            public int day, month, year;
        }

        static void Main(string[] args)
        {
            student[] std = new student[5];

            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Enter Student ID: ");
                std[i].studentID = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                std[i].studentName = Console.ReadLine();

                Console.Write("Enter Course Name: ");
                std[i].courseName = Console.ReadLine();

                Console.Write("Enter Date of Birth: \nEnter Day: ");
                std[i].day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Month: ");
                std[i].month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Year: ");
                std[i].year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");
            }

            Console.WriteLine("\n\n-----STUDENTS LIST-----\n");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Student ID: " + std[i].studentID);
                Console.WriteLine("Student Name: " + std[i].studentName);
                Console.WriteLine("Student Date of Birth (DD/MM/YYYY): " + std[i].day + "/" + std[i].month + "/" + std[i].year);
                Console.WriteLine("Applied Course Name: " + std[i].courseName);

                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
