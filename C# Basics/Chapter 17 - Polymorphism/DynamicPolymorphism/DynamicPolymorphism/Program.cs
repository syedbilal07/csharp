using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        abstract class Shape
        {
            public abstract int area();
        }
        class Rectangle : Shape
        {
            private int length;
            private int width;
            public Rectangle(int l, int w)
            {
                length = l;
                width = w;
            }
            public override int area()
            {
                Console.WriteLine("Rectangle Class Area");
                return length * width;
            }
        }
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(10,7);
            int area = obj.area();
            Console.WriteLine("Area Is : {0}", area);
            Console.ReadLine();
        }
    }
}
