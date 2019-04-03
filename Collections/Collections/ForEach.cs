using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Collections
{
    class ForEach
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
                Console.WriteLine(obj+ " ");
                
            }
            Console.ReadLine();

        }
    }
}
