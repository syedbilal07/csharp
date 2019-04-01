using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    class Program
    {
        class Line {
            private double length;
            public Line(double l)
            {
                Console.WriteLine("Object Created! Length Is : {0}", l);
                length = l;
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
            Line obj = new Line(10.0);
            double length;
            obj.setLength(6.0);
            length = obj.getLength();
            Console.WriteLine("Length Is : {0}", length);
            Console.ReadKey();
        }
    }
}
