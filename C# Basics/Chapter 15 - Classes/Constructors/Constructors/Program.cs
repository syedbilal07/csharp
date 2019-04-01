using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        class Line {
            private double length;
            public Line()
            {
                Console.WriteLine("Object Created!");
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
            double length;
            obj.setLength(3.0);
            length = obj.getLength();
            Console.WriteLine("Length Is : {0}", length);
            Console.ReadKey();

        }
    }
}
