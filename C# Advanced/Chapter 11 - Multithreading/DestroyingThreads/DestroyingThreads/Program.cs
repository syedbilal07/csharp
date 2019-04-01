using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DestroyingThreads
{
    class Program
    {
        class threading
        {
            public static void CallToChildThread()
            {
                try
                {
                    Console.WriteLine("Child Thread Starts");
                    // do some work, like counting to 10
                    for(int counter = 0; counter <= 10; counter++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(counter + " ");
                    }
                    Console.WriteLine("Child Thread Completed");
                }
                catch(ThreadAbortException e)
                {
                    Console.WriteLine("Thread Abort Exception");
                }
                finally
                {
                    Console.WriteLine("Could Not Catch The Exception");
                }
            }
            static void Main(string[] args)
            {
                ThreadStart childRef = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating The Child Thread");
                Thread childThread = new Thread(childRef);
                childThread.Start();
                //stop the main thread for some time
                Thread.Sleep(2000);
                //now abort the child
                Console.WriteLine("In Main : Aborting The Child Thread");
                childThread.Abort();
                Console.ReadKey();
            }
        }
    }
}
