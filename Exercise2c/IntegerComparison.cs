using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2c
{
    class IntegerComparison
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");

            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("These numbers are equal.");

            }
            else
            {

                if (x > y)
                {
                    Console.WriteLine(x + " is larger");
                }
                else
                {
                    Console.WriteLine(y + " is larger");
                }

            }
        }

    }
}
