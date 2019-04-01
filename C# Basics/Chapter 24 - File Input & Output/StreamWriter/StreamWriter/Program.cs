using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Sonia Iqbal", "Sadia Iqbal", "Beenish Arif"};
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach(string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
