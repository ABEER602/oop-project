using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab_2_task.BL
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student()
        {

        }
        public Student(string name, string address, int year , double fee) : base (name , address) 
        {
            this.year = year;

            this.fee = fee;
        }

        public string getProgram ()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee(double fee)
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public override string toString()
        {
            return ("name :" + name + " address :" + address + " program :" + program + " year :" + year + " fee :" + fee);
        }
    }
}
