using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersByValue
{
    class NumberManipulator {
        public void swap(int x, int y) {
            int temp;
            temp = x; // Store x into temp
            x = y; // Store y into x
            y = temp; /* put temp into y */
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            NumberManipulator n = new NumberManipulator();
            n.swap(a, b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
