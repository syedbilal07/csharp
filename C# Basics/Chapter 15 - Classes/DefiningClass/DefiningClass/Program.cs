using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClass
{
    class Box {
        public double length;
        public double width;

        public double GetVolume()
        {
            return length * width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;
            Box1.length = 2.75;
            Box1.width = 3.25;
            volume = Box1.GetVolume();
            Console.WriteLine("Box 1 Length, Width & Volume : {0},{1}, {2}", Box1.length, Box1.width, volume);
            Box2.length = 4.23;
            Box2.width = 3.35;
            volume = Box2.GetVolume();
            Console.WriteLine("Box 2 Length, Width & Volume : {0},{1}, {2}", Box2.length, Box2.width, volume);
            Console.ReadKey();
        }
    }
}
