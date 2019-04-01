using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunctions
{
    class Program
    {
        class Shape
        {
            protected int height;
            protected int width;
            public Shape(int h, int w)
            {
                height = h;
                width = w;
            }
            public virtual int area()
            {
                Console.WriteLine("Shape Class Area");
                return 0;
            }
        }
        class Rectangle : Shape
        {
            public Rectangle(int h, int w) : base(h, w) { }
            public override int area()
            {
                Console.WriteLine("Rectangle Class Area");
                return height * width;
            }
        }
        class Triangle : Shape
        {
            public Triangle(int h, int w) : base(h, w) { }
            public override int area()
            {
                Console.WriteLine("Triangle Class Area");
                return (height * width /2);
            }
        }
        class Caller
        {
            public void CallArea(Shape sh)
            {
                int area;
                area = sh.area();
                Console.WriteLine("Area : {0}", area);
            }
        }
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(5, 10);
            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}
