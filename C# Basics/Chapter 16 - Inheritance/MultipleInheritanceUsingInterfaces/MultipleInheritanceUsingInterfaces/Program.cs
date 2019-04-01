using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceUsingInterfaces
{
    class Program
    {
        class Shape {
            protected int height;
            protected int width;

            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
            public int getArea()
            {
                return height * width;
            }
        }
        // Base class PaintCost
        public interface PaintCost
        {
            int getCost(int area);
        }
        // Derived class
        class Rectangle : Shape, PaintCost
        {
            public int getCost(int area)
            {
                int cost;
                cost = area * 70;
                return cost;
            }
        }
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.setHeight(5);
            obj.setWidth(7);
            int area = obj.getArea();
            Console.WriteLine("Total area: {0}", area);
            Console.WriteLine("Total paint cost: ${0}", obj.getCost(area));
            Console.ReadLine();
        }
    }
}
