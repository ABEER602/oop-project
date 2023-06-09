using copy_constructor.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.sname = "Jack";
            student s2 = new student(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.Read();
        }
    }
}
