using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLOCK_TASK.For_classes;

namespace CLOCK_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            // default constructor
            clock empty_time = new clock();
            Console.WriteLine("Empty Time: ");
            empty_time.printTime();

            // parametrized constructor (one parameter)
            clock hour_time = new clock(8);
            Console.WriteLine("HOUR Time: ");
            hour_time.printTime();

            // parametrized constructor (two parameter)
            clock minute_time = new clock(8 , 10);
            Console.WriteLine("Minute Time: ");
            minute_time.printTime();

            // parametrized constructor (three parameter)
            clock full_time = new clock(8, 10,10);
            Console.WriteLine("Full Time: ");
            full_time.printTime();

            //increment seconds
            full_time.incrementSecond();
            Console.WriteLine("Full time (increment seconds)");
            full_time.printTime();

            //increment hours
            full_time.incrementHours();
            Console.WriteLine("Full time (increment hours)");
            full_time.printTime();

            //increment minutes
            full_time.incrementMinutes();
            Console.WriteLine("Full time (increment minutes)");
            full_time.printTime();


            //elapsed time
         
            Console.WriteLine("Elapsed time : ");
            full_time.elapsedTime();

            // time difference
            int hr, min, sec;
            Console.WriteLine("ENTER HOURS   : " );
            hr = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER MINUTES : " );
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECONDS : " );
            sec = int.Parse(Console.ReadLine());
            full_time.time_difference(hr, min, sec);


            //check if equal
            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("FLAG " + flag);

            // check if equal with objects
            clock cmp = new clock(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag:" + flag);
            Console.ReadKey();
        }
    }
}
