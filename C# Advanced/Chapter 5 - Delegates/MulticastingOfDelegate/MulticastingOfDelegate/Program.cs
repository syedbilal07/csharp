using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int n);
namespace MulticastingOfDelegate
{
    class Program
    {
        class Delegate
        {
            static int num = 10;
            public static int AddNum(int p)
            {
                num += p;
                return num; // 10 + 5 = 15;
            }
            public static int MultiNum(int q)
            {
                num *= q;
                return num; // 15 * 5 = 75; 
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger nc;
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultiNum);
                //creating multicast
                nc = nc1;
                nc += nc2;
                //calling multicast
                nc(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadLine();

            }
        }
    }
}
