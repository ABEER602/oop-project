using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7_lab
{
    class Program
    {
        class Student
        {
            public string name;
            public string session;
            public bool isDayScholar;
            public int EnteryTestMarks;
            public int HSMarks;

            public double calculateMerit()
            {
                double merit = 0.0;
                return merit;
            }
        }

        class Hostellite : Student
        {
            public int RoomNumber;
            public bool isFridgeAvailable;
            public bool isInternetAvailable;
            public int getHostelFee()
            {
                int fee = 0;
                return fee;
            }
        }
            class DayScholar : Student
            {
                public string pickUpPoint;
                public int busNo;
                public int pickUpDistance;

                public int getBusFee()
                {
                    int fee = 0;
                    return fee;
                }

            }


        

        static void Main(string[] args)
        {
            //---------DAYSCHOLAR-----------
            DayScholar std = new DayScholar();
            std.name = "Ahmad";
            std.busNo = 1;
            Console.WriteLine();
            Console.WriteLine(std.name + " is Allocated Bus" + std.busNo);
            //---------Hostellite----------

            Hostellite stf = new Hostellite();
            stf.name = "Ali";
            stf.RoomNumber = 1;
            Console.WriteLine();
            Console.WriteLine(stf.name + " is Allocated room" + stf.RoomNumber);

            Console.ReadKey();
        }
    }
}
