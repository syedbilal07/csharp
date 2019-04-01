using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int var = 20;
                int* p = &var;
                Console.WriteLine("The Value Is : {0}", var);
                Console.WriteLine("The Address Is : {0}", (int)p);
                Console.ReadKey();
            }
        }
    }
}
