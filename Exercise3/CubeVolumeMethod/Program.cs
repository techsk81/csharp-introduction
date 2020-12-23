using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.CubeVolumeMethod
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the radius of the cube: ");

            CubeVolume v = new CubeVolume();
            v.cubeVolume();
        }

    }
}
