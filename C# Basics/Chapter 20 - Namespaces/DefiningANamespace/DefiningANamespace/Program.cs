using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningANamespace
{
    namespace first_space
    {
        class first
        {
            public void func()
            {
                Console.WriteLine("First Space Function");
            }
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
    class Program
    {
        
        
        static void Main(string[] args)
        {
            first_space.first fc = new first_space.first();
            second_space.second sc = new second_space.second();
            fc.func();
            sc.func();
            Console.ReadKey();
        }
    }
}
