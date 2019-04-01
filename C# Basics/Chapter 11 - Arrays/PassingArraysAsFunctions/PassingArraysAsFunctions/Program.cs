using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArraysAsFunctions
{
    class Program
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;
            for(i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            avg = a.getAverage(balance, 5);
            Console.WriteLine("Average Is : {0}", avg);
            Console.ReadLine();
        }
    }
}
