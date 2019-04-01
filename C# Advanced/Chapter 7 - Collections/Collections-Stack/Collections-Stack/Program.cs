using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");

            Console.WriteLine("Current Stack :");
            foreach(string c in st)
            {
                Console.Write(c + " ");
            }
            st.Push("E");
            st.Push("F");
            Console.WriteLine();
            Console.WriteLine("The Next Poppable Value In Stack Is : {0}", st.Peek());
            Console.WriteLine("Current Stack :");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current Stack :");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadLine();
        }
    }
}
