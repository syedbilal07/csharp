using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedArrays
{
    class Program
    {
        class ParamArrays {
            public int AddElements(params int[] arr)
            {
                int sum = 0;
                foreach(int i in arr)
                {
                    sum += i;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            ParamArrays obj = new ParamArrays();
            int sum;
            sum = obj.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("The Sum Is : {0}", sum);
            Console.ReadKey();
        }
    }
}
