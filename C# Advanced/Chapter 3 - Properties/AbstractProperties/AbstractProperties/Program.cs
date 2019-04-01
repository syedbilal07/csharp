using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProperties
{
    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }
    class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override string Name
        {
            get
            {                
                    return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "07";
            s.Name = "Syed Bilal";
            s.Age = 23;
            Console.WriteLine("Student Info : {0}", s);
            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info : {0}", s);
            Console.ReadLine();
        }
    }
}
