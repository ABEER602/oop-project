using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_8_lab_2_task.BL;

namespace week_8_lab_2_task
{
    class Program
    {
       
      

        static void Main(string[] args)
        {
            List<Person> p = new List<Person>();
            Student s1 = new Student("Ali","Lahore",12,200);
            Student s2 = new Student("Aryan", "Lahore", 2, 300);
            staff s3 = new staff("Amir", "Larkana", "Allied", 2.0);
            staff s4 = new staff("Akmal", "kpk", "Allied", 200.012);
            p.Add(s1);
            p.Add(s2);
            p.Add(s3);
            p.Add(s4);
            foreach(Person r in p)
            {
                Console.WriteLine(r.toString());

            }

            Console.ReadKey();
        }
    }
}
