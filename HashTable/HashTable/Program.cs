using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Empid" , 100);
            ht.Add("EmpName", "Jaffar");
            ht.Add("phNumber", 7075003600);
            ht.Add("Email","jafferjilani.786@gmail.com");
            ht.Add("location", "Guntur");


            foreach(Object key in ht.Keys)
            Console.WriteLine(key +":"+ ht[key]);
            Console.ReadLine();
        }
    }
}
