using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello    World";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            String result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String : {0}", input);
            Console.WriteLine("Replacement String : {0}", result);
            Console.ReadKey();
        }
    }
}
