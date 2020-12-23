using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.SphereVolumeMethod
{
    class SphereVolume
    {
        public void sphereVolume()
        {
            double radius;

            radius = double.Parse(Console.ReadLine());
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Calculated volume of sphere: " + volume);
        }

    }
}
