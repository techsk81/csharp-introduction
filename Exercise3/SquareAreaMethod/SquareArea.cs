using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.SquareAreaMethod
{
    class SquareArea
    {
        public void squareArea()
        {
            double length;
            double area;

            length = double.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Calculated area of square: " + area);
        }

    }
}
