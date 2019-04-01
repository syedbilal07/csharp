#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConditionalAttribute
{
    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
    // Below Class Is A Auto Generated Class Due To Errors
    internal class ConditionalAttribute : Attribute
    {
        private string v;

        public ConditionalAttribute(string v)
        {
            this.v = v;
        }
    }

    class Program
    {
        static void function1()
        {
            MyClass.Message("In Function 1");
            function2();
        }
        static void function2()
        {
            MyClass.Message("In Function 2");
        }
        static void Main(string[] args)
        {
            MyClass.Message("In Main Class");
            function1();
            Console.ReadLine();
        }
    }
}
