using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_WEEK_5_CHALLENGE_.DL;
using UMS_WEEK_5_CHALLENGE_.BL;

namespace UMS_WEEK_5_CHALLENGE_.DL

{
    class DegreeProgramCrud
    {
        static List<DegreeProgram> degree = new List<DegreeProgram>();
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
    }
}
