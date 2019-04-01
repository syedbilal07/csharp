﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void NumberChanger(int n);
namespace AnonymousMethods
{
    class Program
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method : {0}", num);
        }
        public static void MultiNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method : {0}", num);
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };
            //calling the delegate using the anonymous method 
            nc(10); // 10

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);
            //calling the delegate using the named methods 
            nc(5); // 15

            //instantiating the delegate using another named methods 
            NumberChanger nc1 = new NumberChanger(MultiNum);
            nc1(2); //30

            Console.ReadLine();




        }
    }
}
