#define PI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinePreprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
        #if (PI)
            Console.WriteLine("PI Is Defined");
        #else
            Console.WriteLine("PI Is Not Defined");
        #endif
            Console.ReadKey();
        }
    }
}
