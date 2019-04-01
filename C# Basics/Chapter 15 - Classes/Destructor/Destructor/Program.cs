using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Program
    {
        class Line {
            private double length;

            public Line()
            {
                Console.WriteLine("Object Created");
            }
            ~Line()
            {
                Console.WriteLine("Object Destroyed");
            }
            public void setLength(double l)
            {
                length = l;
            }
            public double getLength()
            {
                return length;
            }
        }
        static void Main(string[] args)
        {
            Line obj = new Line();
            obj.setLength(6.0);
            double length = obj.getLength();
            Console.WriteLine("Length Is : {0}", length);
            Console.ReadKey();
        }
    }
}
