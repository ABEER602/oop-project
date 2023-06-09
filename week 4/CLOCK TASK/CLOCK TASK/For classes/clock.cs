using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOCK_TASK.For_classes
{
    class clock
    {
        public int hours;
        public int minutes;
        public int seconds;
        public clock()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clock(int h)
        {
            hours = h;
          
        }
        public clock (int h,int m)
        {
            hours = h;
            minutes = m;
        }
        public clock(int h, int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementHours()
        {
            hours++;
        }
        public void incrementMinutes()
        {
            minutes++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h, int m ,int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clock temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void elapsedTime()
        {
           int time_in_sec;
            time_in_sec = ((hours * 3600) + (minutes * 60) + seconds);
            Console.WriteLine("Elapsed time" + time_in_sec);
        }
        public void RemainingTime()
        {
            int time_in_sec;
            int remain_sec;
            time_in_sec = ((hours * 3600) + (minutes * 60) + seconds);
            remain_sec =(24 * 3600) - time_in_sec;
            Console.WriteLine("Remaining time" + remain_sec);
        }
        public void time_difference(int hr,int min,int sec)

        {

            int Remaining_hr;
            int Remaining_min;
            int Remaining_sec;
            if (hours > hr)
            {
                Remaining_hr = hours - hr;
            }
            else
            {
                Remaining_hr = hr - hours;
            }
            if (minutes > min)
            {
                Remaining_min = minutes - min;
            }
            else
            {
                Remaining_min = min - minutes;
            }
            if (seconds > sec)
            {
                Remaining_sec = seconds - sec;
            }
            else
            {
                Remaining_sec = sec - seconds;
            }
            Console.WriteLine("TIME DIFFERENCE IS:" + Remaining_hr + ":" + Remaining_min + ":" + Remaining_sec);
         }
    }
}

