using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.CubeVolumeMethod

{
    class CubeVolume
    {
        public void cubeVolume()
        {
            double length;

            length = double.Parse(Console.ReadLine());
            double volume = length * length * length;
            Console.WriteLine("Calculated volume of cube: " + volume);
        }
    }
}
