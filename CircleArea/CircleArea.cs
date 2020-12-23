using System;
using System.Collections.Generic;
using System.Text;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.WriteLine("Enter radius: ");

            radius = Convert.ToDouble(Console.ReadLine());

            //area (circle) = 3.14 x radius x radius
            area = Math.PI * radius * radius;

            Console.WriteLine("Calculated area of the circle is: " + area);
            Console.ReadLine();
        }
    }
}
