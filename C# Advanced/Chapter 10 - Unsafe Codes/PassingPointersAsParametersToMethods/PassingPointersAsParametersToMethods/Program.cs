using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingPointersAsParametersToMethods
{
    class Program
    {
        public unsafe void swap(int* p, int *q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
        public static unsafe void Main(string[] args)
        {
            Program obj = new Program();
            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;
            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
            obj.swap(x,y);
            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
            Console.ReadKey();
        }
    }
}
