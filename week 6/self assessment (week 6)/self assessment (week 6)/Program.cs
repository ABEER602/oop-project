using self_assessment__week_6_.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assessment__week_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentPath = "C:\\Users\\abeer\\OneDrive\\Desktop\\Semester 2\\OOP labs\\Student.txt.txt";
            string subjectPath = "C:\\Users\\abeer\\OneDrive\\Desktop\\Semester 2\\OOP labs\\Subject.txt.txt";
            string degreePath = "C:\\Users\\abeer\\OneDrive\\Desktop\\Semester 2\\OOP labs\\DegreeProgram.txt.txt";
            if (SubjectDL.readFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (DegreeProgramDL.readFromFile(degreePath))
            {
                Console.WriteLine("DegreeProgram Data Loaded Successfully");
            }
            if (StudentDL.readFile(studentPath))
            {
                Console.WriteLine("Student Data Loaded Successfully");
            }
            int option;
           
        }
    }
}
