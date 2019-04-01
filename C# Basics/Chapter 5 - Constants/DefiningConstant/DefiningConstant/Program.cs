using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius : ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = r * r * pi;
            Console.WriteLine("Radius : {0}, Area : {1}", r, areaCircle);
            Console.ReadKey();
        }
    }
}
