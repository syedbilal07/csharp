using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessSpecifier
{
    class Program
    {
        class Rectangle {
            public double length;
            public double width;

            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length : {0}", length);
                Console.WriteLine("Width : {0}", width);
                Console.WriteLine("Area : {0}", GetArea());
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 3.75;
            r.width = 4.25;
            r.Display();
            Console.ReadKey();
        }
    }
}
