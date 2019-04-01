using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class Program
    {
        class PrintData {
            public void print(int i)
            {
                Console.WriteLine("Printing i : {0}", i);
            }
            public void print(double d)
            {
                Console.WriteLine("Printing d : {0}", d);
            }
            public void print(string s)
            {
                Console.WriteLine("Printing s : {0}", s);
            }
        }
        static void Main(string[] args)
        {
            PrintData obj = new PrintData();
            obj.print(5);
            obj.print(5.25);
            obj.print("C#");
            Console.ReadLine();
        }
    }
}
