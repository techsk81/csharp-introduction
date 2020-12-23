using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.CircleAreaMethod
{
    class CircleAreaMethod
    {
        public void circleArea()
        {
            double cRadius;
            double cArea;

            cRadius = double.Parse(Console.ReadLine());
            cArea = Math.PI * cRadius * cRadius;
            Console.WriteLine("Calculated area of circle: " + cArea);
        }

    }
}
