using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab_2_task.BL
{
    class staff : Person
    {
        private string school;
        private double pay;

        public staff()
        {

        }

        public staff(string name,string address,string school,double pay) : base(name , address)
        {
            this.school = school ;
            this.pay = pay;
            
        }
       public string getSchool()
        {
            return school;
        }
        public void setSchool (string school)
        {
            this.school = school;
        }
        public double getpay()
        {
            return pay;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            return ("name :" + name + " address :" + address + "School :" + school + " Pay :" + pay);
        }
    }
}
