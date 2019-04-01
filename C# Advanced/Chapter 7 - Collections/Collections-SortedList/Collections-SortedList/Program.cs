﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if(sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("The Name Already Exists!");
            }
            else
            {
                sl.Add("008","Nuha Ali");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach(string k in key)
            {
                Console.WriteLine("k : " + sl[k]);
            }
            Console.ReadLine();
        }
    }
}
