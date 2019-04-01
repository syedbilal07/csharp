using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        class Generics
        {
            static void swap<T>(ref T x, ref T y)
            {
                T temp;
                temp = x;
                x = y;
                y = temp;
            }
            static void Main(string[] args)
            {
                int a, b;
                char c, d;
                a = 10;
                b = 20;
                c = 'I';
                d = 'V';

                //display values before swap:
                Console.WriteLine("Int values before calling swap:");
                Console.WriteLine("a = {0}, b = {1}", a, b);
                Console.WriteLine("Char values before calling swap:");
                Console.WriteLine("c = {0}, d = {1}", c, d);

                //call swap
                swap<int>(ref a, ref b);
                swap<char>(ref c, ref d);

                //display values after swap:
                Console.WriteLine("Int values after calling swap:");
                Console.WriteLine("a = {0}, b = {1}", a, b);
                Console.WriteLine("Char values after calling swap:");
                Console.WriteLine("c = {0}, d = {1}", c, d);

                Console.ReadKey();


            }
        }
    }
}
