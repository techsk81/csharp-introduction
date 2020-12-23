using System;

namespace CircleCircumference
{
    class CircleCircumference
    {
        static void Main(string[] args)
        {

            double radius, perimeter;
            
            Console.WriteLine("Enter radius: ");

            radius = Convert.ToDouble(Console.ReadLine());

            //area (circle) = 3.14 * radius * radius
            perimeter = 2 * Math.PI * radius;

            Console.WriteLine("Calculated perimeter or circumference of the circle is: " + perimeter);
            Console.ReadLine();
            
        }
    }
}
