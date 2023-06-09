using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab_2_task.BL
{
    class Person
    {
        protected string name;
        protected string address;
        public Person()
        {

        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return ("name :" + name + " address :" + address);
        }
    }

}
