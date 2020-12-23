using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2c
{
    class GradeSelection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade (percentage):");

            int grade;
            grade = int.Parse(Console.ReadLine());

            if (grade >= 80)
            {
                Console.WriteLine("Graded as A");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Graded as B");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Graded as C");

            }
            else if (grade <= 35)
            {
                Console.WriteLine("Failed!");
            }
        }

    }
}
