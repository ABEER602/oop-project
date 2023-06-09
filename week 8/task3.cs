using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab_3_task
{
    class Program
    {
        class Animal
        {
            protected string name;
            public Animal ()
            {

            }
            public Animal(string name)
            {
                this.name = name;
            }
        public virtual string toString ()
            {
                return ("Name :" + name);
            }
        }
        class Mammal : Animal 
        { 
            public Mammal()
            {

            }
           public Mammal (string name) : base (name)
            {

            }
            public override string toString()
            {
                return ("Name :" + name);
            }
        }
        class Cat : Mammal
        { 
            public Cat()
            {

            }
            public Cat (string name) : base (name)
            {

            }
            public override void greets ()
            {
                Console.WriteLine("Meow");
            }
            public override string toString()
            {
                return base.toString();
            }
        }
        class Dog : Mammal
        { 
            public Dog()
            {

            }
        public Dog (string name) 
        {
                
        }
            public void greets()
            {
                Console.WriteLine("Woof");
            }
            public override string toString()
            {
                return base.toString();
            }

        }


        static void Main(string[] args)
        {
        }
    }
}
