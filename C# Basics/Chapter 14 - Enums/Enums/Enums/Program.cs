using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Days {Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        static void Main(string[] args)
        {
            int WeekStart = (int)Days.Monday;
            int WeekEnd = (int)Days.Sunday;
            Console.WriteLine("Monday : {0}", WeekStart);
            Console.WriteLine("Sunday : {0}", WeekEnd);
            Console.ReadKey();
        }
    }
}
