using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7__Challenge_2_
{
    class Program
    {
        class Bicycle
        {
            private int cadence;
            private int gear;
            private int speed;

            public void setCadence(int cardence)
            {
                this.cadence = cardence;

            }
            public void setgear(int gear)
            {
                this.gear = gear;

            }
            public void applyBrake(int decrement)
            {

            }
            public void speedUp(int increment)
            {

            }
        }
        class MountainBike : Bicycle
        { 
            private int seatHeight;
            public MountainBike(int seatHeight , int cadence , int speed , int gear)
            {
                this.seatHeight = seatHeight;
                this.
            }
        }
       


        static void Main(string[] args)
        {
        }
    }
}
