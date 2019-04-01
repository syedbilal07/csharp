using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIndexers
{
    class Program
    {
        class Indexer
        {
            private string[] namelist = new string[size];
            public static int size = 10;
            public Indexer()
            {
                for (int i = 0; i < size; i++)
                {
                    namelist[i] = "N.A";
                }
            }
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= size - 1)
                    {
                        tmp = namelist[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return tmp;
                }
                set
                {
                    if (index >= 0 && index <= size - 1)
                    {
                        namelist[index] = value;
                    }
                }
            }
            static void Main(string[] args)
            {
                Indexer names = new Indexer();
                names[0] = "Wajeeha";
                names[1] = "Beenish";
                names[2] = "Sadia";
                names[3] = "Bilal";
                names[4] = "Huzaifa";
                names[5] = "Ammar";
                names[6] = "Hasan";
                for (int i = 0; i < Indexer.size; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
