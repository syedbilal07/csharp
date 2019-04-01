using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingArrayElementsUsingAPointer
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            int[] list = { 10, 100, 200 };
            fixed(int* ptr = list)

            /* let us have array address in pointer */
            for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address Of List[{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Value Of List[{0}] = {1}", i, *(ptr + i));
                }
            Console.ReadKey();
        }
    }
}
