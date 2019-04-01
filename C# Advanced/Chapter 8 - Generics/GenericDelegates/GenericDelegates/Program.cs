using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// delegate of generic type
delegate T NumberChanger<T>(T n);

namespace GenericDelegates
{
    class Program
    {
        class Delegation
        {
            static int num = 10;
            public static int AddNum(int p)
            {
                num += p;
                return num;
            }
            public static int MultiNum(int q)
            {
                num *= q;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
                NumberChanger<int> nc2 = new NumberChanger<int>(MultiNum);

                //calling the methods using the delegate objects
                nc1(25); // 25 + 10 = 35
                Console.WriteLine("Value of Num: {0}", getNum());
                nc2(5); // 25 * 5 = 125, 10 * 5 = 50;
                // 125 + 50 = 175;
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();

            }
        }
    }
}
