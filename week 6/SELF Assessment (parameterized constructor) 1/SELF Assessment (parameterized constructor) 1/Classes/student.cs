using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELF_Assessment__parameterized_constructor__1.Classes
{
    class student
    {
        public student(string name,float matric_marks, float Fsc_marks, float Ecat_marks,float Agregate)
        {
            sname = name;
            matricMarks = matric_marks;
            fscMarks = Fsc_marks;
            ecatMarks = Ecat_marks;
            agregate = Agregate;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float agregate;
    }
}
