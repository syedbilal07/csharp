using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DeclaringACustomAttribute
{
    //a custom attribute BugFix to be assigned to a class and its members
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]
    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DebugInfo(int bg, string dev, string lr)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = lr;
        }
        public int bug
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string lastRev
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
        
        class Program
        {
        [DebugInfo(45, " Syed Bilal", "12/8/2012", Message = "Return type mismatch")]
        [DebugInfo(49, "Huzaifa Hassan", "10/10/2012", Message = "Unused variable")]
        class Rectangle
            {
                //member variables
                protected double length;
                protected double width;
                public Rectangle(double l, double w)
                {
                    length = l;
                    width = w;
                }
                [DebugInfo(55, "Sadia Iqbal", "19/10/2012", Message = "Return type mismatch")]
                public double GetArea()
                {
                    return length * width;
                }
                [DebugInfo(56, "Sadia Iqbal", "19/10/2012")]
                public void Display()
                {
                    Console.WriteLine("Length: {0}", length);
                    Console.WriteLine("Width: {0}", width);
                    Console.WriteLine("Area: {0}", GetArea());
                }
            }
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(7.5, 4.5);
                r.Display();
                Type type = typeof(Rectangle);

                //iterating through the attributes of the Rectangle class
                foreach(Object attributes in type.GetCustomAttributes(false))
                {
                    DebugInfo dbi = (DebugInfo)attributes;
                    if(null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}", dbi.bug);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.lastRev);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
                //iterating through the method attribtues
                foreach(MethodInfo m in type.GetMethods())
                {
                    foreach(Attribute a in m.GetCustomAttributes(true))
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if(null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.bug, m.Name);
                            Console.WriteLine("Developer: {0}", dbi.Developer);
                            Console.WriteLine("Last Reviewed: {0}", dbi.lastRev);
                            Console.WriteLine("Remarks: {0}", dbi.Message);
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    
}
