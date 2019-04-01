using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberFunctionsAndEncapsulation
{
    class Box {
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
        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
        public double getBreadth()
        {
            return breadth;
        }
        public double getVolume()
        {
            return length * breadth * width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            Box1.setLength(6.0);
            Box1.setWidth(7.0);
            Box1.setBreadth(5.0);
            volume = Box1.getVolume();
            Console.WriteLine("Volume Of Box 1 Is : {0}", volume);

            Box2.setLength(12.0);
            Box2.setWidth(13.0);
            Box2.setBreadth(10.0);
            volume = Box2.getVolume();
            Console.WriteLine("Volume Of Box 2 Is : {0}", volume);
            Console.ReadKey();
        }
    }
}
