using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Books {
    private string author;
    private string title;
    private string subject;
    private int id;

    public void getValues(string a, string t, string s, int i)
    {
        author = a;
        title = t;
        subject = s;
        id = i;
    }
    public void display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("ID : {0}", id);
    }
};

namespace ClassVsStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("Anders Hejlsberg", "C# Guide Book", "C# Tutorials", 1);
            Book2.getValues("Anders Hejlsberg", "C# Cook Book", "C# World", 2);

            Book1.display();
            Console.WriteLine();
            Book2.display();
            Console.ReadKey();
        }
    }
}
