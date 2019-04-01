using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersByOutput1
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            Console.WriteLine("Before Function Call, Value Of a Is : {0}", a);
            n.getValue(out a);
            Console.WriteLine("After Function Call, Value Of a Is : {0}", a);
            Console.ReadLine();
        }
    }
}
