using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assessment__week_6_.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public List<Subject> subjects;
        public int seats;

        public DegreeProgram(string degreeName,float degreeDuration,int seats)
        {
            this.degreeDuration = degreeDuration;
            this.degreeName = degreeName;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public bool isSubjectExists(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;

                }
            }
            return false;
        }

        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].creditHours;
            }
            return count;
        }

        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
