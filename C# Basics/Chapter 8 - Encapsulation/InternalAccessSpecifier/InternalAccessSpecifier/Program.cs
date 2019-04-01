using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifier
{
    class Program
    {
        class Rectangle {
            internal double length;
            internal double width;

            double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        } 
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 2.75;
            r.width = 3.25;
            r.Display();
            Console.ReadKey();
        }
    }
}
