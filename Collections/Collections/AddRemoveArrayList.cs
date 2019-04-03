using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Collections
{
    class AddRemoveArrayList
    {
        static void Main(String[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);

            foreach (Object obj in al)
            {
                Console.WriteLine(obj + " ");
            }
            al.Insert(1,250); // Inserting
            al.Remove(400);  // Removing

            Console.ReadLine();
        }
    }
}
