using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if(ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("The Student Name Is Already In The List");
            }
            else
            {
                ht.Add("008","Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach(string k in key)
            {
                Console.WriteLine("k : " + ht[k]);
            }
            Console.ReadLine();
        }
    }
}
