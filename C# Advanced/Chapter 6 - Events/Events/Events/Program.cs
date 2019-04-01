using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate string MyDelegate(string str);
    class Program
    {
        class EventProgram
        {
            event MyDelegate MyEvent;

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }
            public EventProgram()
            {
                this.MyEvent += new MyDelegate(this.WelcomeUser);
            }
            static void Main(string[] args)
            {
                EventProgram obj = new EventProgram();
                string result = obj.MyEvent("To Events!");
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
