using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingArraysUsingForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            
            for(int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            foreach(int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] : {1}", i, j);
            }
            Console.ReadLine();
        }
    }
}
