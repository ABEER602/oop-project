using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task__week_3_.classes;

namespace task__week_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  for object 1
            user s1 = new user("JOHN");
            Console.WriteLine("OBJECT 1");

            Console.WriteLine("Name: " + s1.sname);
            Console.WriteLine();

            //  for object 2
            Console.WriteLine("OBJECT 2");
         
            user s2 = new user("Jack");
            Console.WriteLine("Name: " + s2.sname);
            Console.Read();
         
        }
    }
}
