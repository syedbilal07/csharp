﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_space;
using second_space;
namespace first_space
{
    public class first
    {
        public void func()
        {
            Console.WriteLine("First Space Function");
        }
    }
}
namespace second_space
{
    public class second
    {
        public void func()
        {
            Console.WriteLine("Second Space Function");
        }
    }
}
namespace UsingDirective
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            first fc = new first();
            second sc = new second();
            fc.func();
            sc.func();
            Console.ReadKey();
        }
    }
}
