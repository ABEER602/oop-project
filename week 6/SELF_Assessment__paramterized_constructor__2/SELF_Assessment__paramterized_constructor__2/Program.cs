using SELF_Assessment__paramterized_constructor__2.CLASSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELF_Assessment__paramterized_constructor__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            float matric_marks;
            float Fsc_marks;
            float Ecat_marks;
            float Agregate;
            //  for object 1
            
            Console.WriteLine("ENTER Name: ");
            name = Console.ReadLine();
            Console.WriteLine("ENTER Matric marks: ");
            matric_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER FSC marks: ");
            Fsc_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ECAT marks: ");
            Ecat_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER Agregate marks: ");
            Agregate = int.Parse(Console.ReadLine());
            student s1 = new student(name, matric_marks, Fsc_marks, Ecat_marks, Agregate);
            Console.WriteLine("OBJECT 1");
            Console.WriteLine();
            Console.WriteLine("Name: " + s1.sname);
            Console.WriteLine("Matric marks: " + s1.matricMarks);
            Console.WriteLine("FSC marks: " + s1.fscMarks);
            Console.WriteLine("ECAT marks: " + s1.ecatMarks);
            Console.WriteLine("Agregate marks: " + s1.agregate);
            //  for object 2
            Console.WriteLine();
            Console.WriteLine("OBJECT 2");
            Console.WriteLine("ENTER Name: ");
            name = Console.ReadLine();
            Console.WriteLine("ENTER Matric marks: ");
            matric_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER FSC marks: ");
            Fsc_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ECAT marks: ");
            Ecat_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER Agregate marks: ");
            Agregate = int.Parse(Console.ReadLine());
            student s2 = new student(name, matric_marks, Fsc_marks, Ecat_marks, Agregate);
            Console.WriteLine();
            Console.WriteLine("OBJECT 2");
            Console.WriteLine("Name: " + s2.sname);
            Console.WriteLine("Matric marks: " + s2.matricMarks);
            Console.WriteLine("FSC marks: " + s2.fscMarks);
            Console.WriteLine("ECAT marks: " + s2.ecatMarks);
            Console.WriteLine("Agregate marks: " + s2.agregate);

            Console.ReadKey();

        }
    }
}
