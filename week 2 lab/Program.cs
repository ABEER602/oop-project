using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tasks
{
    class Program
    {
        class students
        {
            public string name;
            public int rollno;
            public float cgpa;

        }
        class student2
        {
            public string name;
            public int rollno;
            public float cgpa;
            public char isHostellite;
            public string department;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT 1");
            students s1 = new students();
            s1.name = "Abeer";
            s1.rollno = 12;
            s1.cgpa = 3.4F;
            Console.WriteLine("NAME: " + s1.name + "ROLLNO: " + s1.rollno + "CGPA " + s1.cgpa);


            Console.WriteLine();
            Console.WriteLine("STUDENT 2");
            students s2 = new students();
            s2.name = "Ahamd";
            s2.rollno = 22;
            s2.cgpa = 2.4F;
            Console.WriteLine("NAME: " + s2.name + "ROLLNO: " + s2.rollno + "CGPA " + s2.cgpa);
            Console.WriteLine();
            Console.WriteLine("TAKING INPUTS");
            Console.WriteLine("ENTER NAME");
            s1.name = Console.ReadLine();
            Console.WriteLine("ENTER ROLLNO");
            s1.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER CGPA");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("NAME: " + s1.name + "ROLLNO: " + s1.rollno + "CGPA " + s1.cgpa);


            Console.WriteLine();
            Console.WriteLine("TOP USERS");
            student2[] v = new student2[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    v[count] = add_Students();
                    count = count + 1;

                }
                else if (option == '2')
                {
                    View_Student(v, count);
                }
                else if (option == '3')
                {
                    Top_Student(v, count);
                }
                else if (option == '4')
                {
                    break;
                }
            }
            while (option != '4');
            Console.WriteLine("Press enter to exit");
            Console.Read();


        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 for Add student: ");
            Console.WriteLine("Press 2 for View student: ");
            Console.WriteLine("Press 3 for Top Three Students: ");
            Console.WriteLine("Press 4 to exit: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static student2 add_Students()
        {
            student2 v1 = new student2();
            Console.WriteLine("ENTER NAME");
            v1.name = Console.ReadLine();
            Console.WriteLine("ENTER ROLLNO");
            v1.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER CGPA");
            v1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR DEPARTMENT");
            v1.department = Console.ReadLine();
            Console.WriteLine("ARE YOU HOSTELLITE (y/n)");
            v1.isHostellite = char.Parse(Console.ReadLine());
            return v1;
        
        }
        static void View_Student(student2[] v, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("NAME: " + v[i].name + "ROLLNO: " + v[i].rollno + "CGPA: " + v[i].cgpa + "DEPARTMENT: " + v[i].department + "HOSTELLITE" + v[i].isHostellite);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
        static void Top_Student(student2[] v, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("NO RECORD PRESENT");
            }
            else if (count == 1)
            {
                View_Student(v, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(v, x, count);
                    student2 temp = v[index];
                    v[index] = v[x];
                    v[x] = temp;
                }
                View_Student(v, 3);
            }

        }
        static int largest(student2[] v, int start, int end)
        {
            int index = start;
            float large = v[start].cgpa;
            for (int x = start; x < end; x++)
            {
                if (large < v[x].cgpa)
                {
                    large = v[x].cgpa;
                    index = x;
                }
            }
            return index;
        }

    }
}
