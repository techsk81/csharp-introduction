using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2c
{
    class OddOrEven
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to determine if it is odd or even:");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

        }

    }
}
