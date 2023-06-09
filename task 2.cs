using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2_week_3_lab_.classes;

namespace task2_week_3_lab_
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------Task 2-------(printing attributes using default constructor)-------
         //  for object 1
            student s1 = new student();
            Console.WriteLine("OBJECT 1");
            Console.WriteLine();
            Console.WriteLine("Name: " + s1.sname);
            Console.WriteLine("Matric marks: " + s1.matricMarks);
            Console.WriteLine("FSC marks: " + s1.fscMarks);
            Console.WriteLine("ECAT marks: " + s1.ecatMarks);
            Console.WriteLine("Agregate marks: " + s1.agregate);
            //  for object 2
            Console.WriteLine("OBJECT 2");
            Console.WriteLine();
            student s2 = new student();
            Console.WriteLine("Name: " + s2.sname);
            Console.WriteLine("Matric marks: " + s2.matricMarks);
            Console.WriteLine("FSC marks: " + s2.fscMarks);
            Console.WriteLine("ECAT marks: " + s2.ecatMarks);
            Console.WriteLine("Agregate marks: " + s2.agregate);
            //  for object 3
            Console.WriteLine("OBJECT 3");
            Console.WriteLine();
            student s3 = new student();
            Console.WriteLine("Name: " + s3.sname);
            Console.WriteLine("Matric marks: " + s3.matricMarks);
            Console.WriteLine("FSC marks: " + s3.fscMarks);
            Console.WriteLine("ECAT marks: " + s3.ecatMarks);
            Console.WriteLine("Agregate marks: " + s3.agregate);
            Console.Read();
        }
    }
}
