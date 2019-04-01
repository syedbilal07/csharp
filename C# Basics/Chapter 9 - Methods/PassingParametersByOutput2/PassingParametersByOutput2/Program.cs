using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersByOutput2
{
    class NumberManipulator
    {
        public void getValue(out int x, out int y)
        {
            Console.WriteLine("Enter First Value : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value : ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;
            n.getValue(out a, out b);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
