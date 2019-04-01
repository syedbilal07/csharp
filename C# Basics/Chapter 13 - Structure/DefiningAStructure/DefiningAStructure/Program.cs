using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Books {
    public string title;
    public string author;
    public string subject;
    public int id;
};

namespace DefiningAStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Books Book1; /* Declare Book1 of type Book */
            Books Book2; /* Declare Book2 of type Book */
            /* book 1 specification */
            Book1.id = 1;
            Book1.title = "C# Programming";
            Book1.author = "Anders Hejlsberg";
            Book1.subject = "C# Guide Book";
            /* book 2 specification */
            Book2.id = 2;
            Book2.title = "C# World";
            Book2.author = "Anders Hejlsberg";
            Book2.subject = "C# Cook Book";

            /* print Book1 info */
            Console.WriteLine("Book 1 Id Is : {0}", Book1.id);
            Console.WriteLine("Book 1 Title Is : {0}", Book1.title);
            Console.WriteLine("Book 1 Subject Is : {0}", Book1.subject);
            Console.WriteLine("Book 1 Author Is : {0}", Book1.author);
            Console.WriteLine();
            /* print Book2 info */
            Console.WriteLine("Book 2 Id Is : {0}", Book2.id);
            Console.WriteLine("Book 2 Title Is : {0}", Book2.title);
            Console.WriteLine("Book 2 Subject Is : {0}", Book2.subject);
            Console.WriteLine("Book 2 Author Is : {0}", Book2.author);

            Console.ReadKey();



        }
    }
}
