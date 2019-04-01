using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TheMainThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "Main Thread";
            Console.WriteLine("This Is : {0}", th.Name);
            Console.ReadKey();
        }
    }
}
