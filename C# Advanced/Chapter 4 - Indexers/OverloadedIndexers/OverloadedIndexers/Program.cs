using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedIndexers
{
    class Program
    {
        class Indexer
        {
            private string[] namelist = new string[size];
            public static int size = 10;
            public Indexer()
            {
                for(int i = 0; i < size; i++)
                {
                    namelist[i] = "N.A";
                }
            }
            public string this[int index]
            {
                get
                {
                    string tmp;

                    if(index >= -0 && index <= size -1)
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
                    if(index >= 0 && index <= size - 1)
                    {
                        namelist[index] = value;
                    }
                }
            }
            public int this[string name]
            {
                get
                {
                    int index = 0;
                    while(index < size)
                    {
                        if(namelist[index] == name)
                        {
                            return index;
                        }
                        index++;
                    }
                    return index;
                }
            }
        }
        static void Main(string[] args)
        {
            Indexer names = new Indexer();
            names[0] = "Bilal";
            names[1] = "Huzaifa";
            names[2] = "Beenish";
            names[3] = "Asif";
            names[4] = "Sadia";
            names[5] = "Wajeeha";
            names[6] = "Ruby";
            //using the first indexer with int parameter
            for (int i =0; i < Indexer.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            //using the second indexer with the string parameter
            Console.WriteLine(names["Beenish"]);
            Console.ReadLine();
        }
    }
}
