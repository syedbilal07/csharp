using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
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
        public string Name
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
        public int Age
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
            Student st = new Student();
            st.Code = "07";
            st.Name = "Syed Bilal";
            st.Age = 23;
            Console.WriteLine("Student Info : {0}", st);
            //let us increase age
            st.Age += 1;
            Console.WriteLine("Student Info : {0}", st);
            Console.ReadKey();
        }
    }
}
