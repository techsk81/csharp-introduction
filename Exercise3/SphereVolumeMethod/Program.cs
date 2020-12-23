using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.SphereVolumeMethod
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the radius of the sphere: ");

            SphereVolume v = new SphereVolume();
            v.sphereVolume();
        }

    }
}
