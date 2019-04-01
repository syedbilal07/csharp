using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;
            // cast double to int.
            i = (int)d;
            Console.WriteLine("Value Of Int :{0}", i);
            Console.ReadKey();
        }
    }
}
