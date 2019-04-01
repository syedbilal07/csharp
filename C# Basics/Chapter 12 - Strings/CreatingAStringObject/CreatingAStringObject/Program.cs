using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAStringObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Syed";
            lname = "Bilal";
            string fullname = fname + lname;
            Console.WriteLine("My Name Is : {0}", fullname);

            //by using string constructor
            char[] letters = {'H', 'e', 'l','l','o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings : {0}", greetings);

            //methods returning string
            string[] sarray = { "Hello", "From", "Tutorialspoint" };
            string greeting = String.Join(" ", sarray);
            Console.WriteLine("Greetings : {0}", greetings);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


            Console.ReadKey();
        }
    }
}
