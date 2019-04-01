using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CreatingThreads
{
    class Program
    {
        class Threading
        {
            public static void CallToChildThread()
            {
                Console.WriteLine("Child Thread Starts");
            }
            static void Main(string[] args)
            {
                ThreadStart child = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating The Child Thread");
                Thread childThread = new Thread(child);
                childThread.Start();
                Console.ReadKey();
            }
        }
    }
}
