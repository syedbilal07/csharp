using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Using_Delegates
{
    class Program
    {
        class Delegate
        {
            static FileStream fs;
            static StreamWriter sw;

            // delegate declaration
            public delegate void printString(string s);

            // this method prints to the console
            public static void WriteToScreen(string str)
            {
                Console.WriteLine("The String Is : {0}", str);
            }
            //this method prints to a file
            public static void WriteToFile(string s)
            {
                fs = new FileStream("C:\file.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            // this method takes the delegate as parameter and uses it to
            // call the methods as required
            public static void SendString(printString ps)
            {
                ps("Hello Delegates!");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
