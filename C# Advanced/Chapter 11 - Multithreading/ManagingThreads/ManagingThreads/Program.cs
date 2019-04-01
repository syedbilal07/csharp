using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ManagingThreads
{
    class Program
    {
        class Threading
        {
            public static void CallToChildThread()
            {
                Console.WriteLine("Creating Child Thread");
                int sleep = 5000;
                Console.WriteLine("Child Thread Paused For : {0}", sleep / 1000);
                Thread.Sleep(sleep);
                Console.WriteLine("Child Thread Resumes");
            }

            static void Main(string[] args)
            {
                ThreadStart childRef = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main : Creating The Child Thread");
                Thread childThread = new Thread(childRef);
                childThread.Start();
                Console.ReadKey();
            }
        }
    }
}
