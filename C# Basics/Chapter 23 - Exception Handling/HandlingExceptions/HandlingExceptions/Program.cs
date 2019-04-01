using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        class Division
        {
            int result;
            Division()
            {
                result = 0;
            }
            public void DivNumber(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Divide By Zero Exception Caught : {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result : {0}", result);
                }
            } 
        static void Main(string[] args)
        {
                Division div = new Division();
                div.DivNumber(25, 0);
                Console.ReadKey();


        }
      }
    }
}
