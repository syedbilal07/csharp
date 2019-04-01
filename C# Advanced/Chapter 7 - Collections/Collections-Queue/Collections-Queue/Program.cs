using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            q.Enqueue("D");
            Console.WriteLine("Current Queue :");
            foreach(string a in q)
            {
                Console.WriteLine(a + " ");
            }
            Console.WriteLine("Removing Some Values ");
            string ch = (string)q.Dequeue();
            Console.WriteLine("The Removed Values Is : {0}", ch);
            ch = (string)q.Dequeue();
            Console.WriteLine("The Removed Values Is : {0}", ch);
            Console.WriteLine("Current Queue :");
            foreach (string a in q)
            {
                Console.WriteLine(a + " ");
            }
            Console.ReadLine();
        }
    }
}
