using System;
using System.Collections;

namespace Collections
{
    class AutoResizing
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
           
            Console.WriteLine(al.Capacity);
            Console.ReadLine();
        }
    }
}
