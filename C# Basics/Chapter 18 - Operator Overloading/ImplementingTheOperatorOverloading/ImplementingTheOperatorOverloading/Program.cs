using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingTheOperatorOverloading
{
    class Program
    {
        class Box
        {
            private double length;
            private double width;
            private double breadth;

            public void setLength(double l)
            {
                length = l;
            }
            public void setWidth(double w)
            {
                width = w;
            }
            public void setBreadth(double b)
            {
                breadth = b;
            }
            public double getVolume()
            {
                return length * breadth * width;
            }
            public static Box operator+ (Box Box1, Box Box2)
            {
                Box box = new Box();
                box.length = Box1.length + Box2.length;
                box.width = Box1.width + Box2.width;
                box.breadth = Box1.breadth + Box2.breadth;
                return box;
            }
        }
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume;
            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setWidth(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setWidth(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();


        }
    }
}
