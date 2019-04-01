using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndDerivedClasses
{
    class Program
    {
        class Shape {
            protected int width;
            protected int height;

            public void setHeight(int h) {
                height = h;
            }
            public void setWidth(int w)
            {
                width = w;
            }
            public int getHeight()
            {
                return height;
            }
            public int getWidth()
            {
                return width;
            }
        }
        class Rectangle: Shape{
            public int getArea()
            {
                return height * width;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int area;
            r.setHeight(6);
            r.setWidth(7);
            area = r.getArea();
            Console.WriteLine("Area Is : {0}", area);
            Console.ReadKey();
        }
    }
}
