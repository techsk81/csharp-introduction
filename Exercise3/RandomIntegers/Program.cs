using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.RandomIntegers
{
    class Program
    {
        static void Main()
        {
            Random randomNumbers = new Random();
            int n;
            
            n = randomNumbers.Next(1, 5);
            Console.WriteLine($"randomNumbers.Next(1, 5) = {n}");
            
            n = randomNumbers.Next(1, 22);
            Console.WriteLine($"randomNumbers.Next(1, 5) = {n}");
            
            n = randomNumbers.Next(0, 29);
            Console.WriteLine($"randomNumbers.Next(0, 29) = {n}");
            
            n = randomNumbers.Next(1000, 1112);
            Console.WriteLine($"randomNumbers.Next(1000, 1112) = {n}");
            
            n = randomNumbers.Next(-1, 7);
            Console.WriteLine($"randomNumbers.Next(-1, 7) = {n}");
            
            n = randomNumbers.Next(-13, 21);
            Console.WriteLine($"randomNumbers.Next(-13, 21) = {n}");
        }

    }
}
