using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_WEEK_5_CHALLENGE_.BL;

namespace UMS_WEEK_5_CHALLENGE_.DL
{

    class StudentCrud
    {
        static List<Student> studentList = new List<Student>();

        static Student StudentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "has" + s.calculateFee() + "fees");
                    return s;
                }
            }
            return null;
        }
        static void calculateFeeForAll()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "has" + s.calculateFee() + "fees");
                }
            }
        }
        static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register:");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject code:");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter valid course:");
                    x--;
                }
            }
        }

        static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = sortedStudentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }

    }
}
