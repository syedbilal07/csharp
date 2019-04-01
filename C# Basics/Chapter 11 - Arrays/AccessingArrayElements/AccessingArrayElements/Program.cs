using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i, j;

            for (i = 0; i < 10; i++) {
                n[i] = i + 100;
            }
            for (j = 0; j < 10; j++) {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadLine();
        }
    }
}
