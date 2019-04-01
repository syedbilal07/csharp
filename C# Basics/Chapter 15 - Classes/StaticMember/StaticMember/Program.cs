using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Program
    {
        class staticVar {
            public static int num;
            public void count() {
                num++;
            }
            public int getCount()
            {
                return num;
            }
        }
        static void Main(string[] args)
        {
            staticVar s1 = new staticVar();
            staticVar s2 = new staticVar();
            // calling function
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("Variable num for s1: {0}", s1.getCount());
            Console.WriteLine("Variable num for s2: {0}", s2.getCount());
            Console.ReadKey();
        }
    }
}
