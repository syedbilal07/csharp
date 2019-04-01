using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 10;
            /* while loop execution */
            while (a < 20) {
                Console.WriteLine("Value Of a : {0}", a);
                a++;
                if (a > 15) {
                    /* terminate the loop using break statement */
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
