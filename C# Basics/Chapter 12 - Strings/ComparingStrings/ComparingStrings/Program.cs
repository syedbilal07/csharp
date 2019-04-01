using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal");
            }
            Console.ReadKey();
        }
    }
}
