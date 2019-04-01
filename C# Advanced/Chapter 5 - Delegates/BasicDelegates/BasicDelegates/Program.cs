using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int n);
namespace BasicDelegates
{
    class Program
    {
        class Delegate
        {
            static int num = 10;
            public static int AddNum(int p)
            {
                num += p; // num = num + p;
                return num; // 10 + 5 = 15;
            }
            public static int MultiNum(int q)
            {
                num *= q; // num = num * q;
                return num; // 10 * 10 * 5 = 150;
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger d1 = new NumberChanger(AddNum);
                NumberChanger d2 = new NumberChanger(MultiNum);
                //calling the methods using the delegate objects
                d1(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                d2(10);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadLine();
            }
        }
    }
}
