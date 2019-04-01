using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFunction
{
    class Program
    {
        class staticFunction {
            public static int num;

            public void setCount() {
                num++;
            }
            public static int getCount()
            {
                return num;
            }
        }
        static void Main(string[] args)
        {
            staticFunction obj = new staticFunction();
            obj.setCount();
            obj.setCount();
            obj.setCount();
            Console.WriteLine("Variable num : {0}", staticFunction.getCount());
            Console.ReadKey();
        }
    }
}
