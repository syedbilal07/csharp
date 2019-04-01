using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Add {
        public int FindMax(int num1, int num2) {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else {
                result = num2;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            Console.WriteLine("Max(10,20) : {0}", a.FindMax(10, 20));
            Console.Read();
        }
    }
}
