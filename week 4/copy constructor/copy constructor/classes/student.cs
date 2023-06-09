using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor.classes
{
    class student
    {
        public student()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR CALLED");
        }
        public student(student s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            agregate = s.agregate;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float agregate;
    }
    }

