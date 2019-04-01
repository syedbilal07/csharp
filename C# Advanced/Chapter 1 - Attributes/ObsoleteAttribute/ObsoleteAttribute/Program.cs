using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsoleteAttribute
{
    class Program
    {
        [Obsolete("Please Don't Use Old Method, Use New Instead", true)]
        static void OldMethod()
        {
            Console.WriteLine("This Is A Old Method");
        }
        static void NewMethod()
        {
            Console.WriteLine("This Is A New Method");
        }
        static void Main(string[] args)
        {
            OldMethod();
            Console.ReadLine();
        }
    }

    internal class ObsoleteAttribute : Attribute
    {
        private string v1;
        private bool v2;

        public ObsoleteAttribute(string v1, bool v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
