using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_space;
using first_space.second_space;
namespace first_space
{
    class first
    {
        public void func()
        {
            Console.WriteLine("First Space Function");
        }
    }
    namespace second_space
    {
        class second
        {
            public void func()
            {
                Console.WriteLine("Second Space Function");
            }
        }
    }
}

namespace NestedNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            first fc = new first();
            second sc = new second();
            fc.func();
            sc.func();
            Console.ReadKey();

        }
    }
}
