using System;
using System.Collections.Generic;
using System.Text;

namespace CubeVolume
{
    class CubeVolume
    {

        static void Main(string[] args)
        {
            int length = 10;

            //volume (Cube) = length x length x length
            int volume = length * length * length;

            Console.WriteLine("Calculated volume of a cube is: " + volume);
        }  

    }
}
