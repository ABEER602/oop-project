using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.UL
{
    class menu
    {

        public int Menu()
        {
            int option;
            Console.WriteLine("Press 1 TO MAKE LINE");
            Console.WriteLine("Press 2 TO UPDATE START POINT");
            Console.WriteLine("Press 3 To UPDATE END POINT");
            Console.WriteLine("Press 4 To SHOW START POINT");
            Console.WriteLine("Press 5 To SHOW END POINT");
            Console.WriteLine("Press 6 To GET THE GRADIENT OF LINE");
            Console.WriteLine("Press 7 To FIND THE DISTANCE OF START POINT");
            Console.WriteLine("Press 8 To FIND THE DISTANCE OF END POINT");
            Console.WriteLine("Press 9 To GET LENGTH");
            Console.WriteLine("Press 10 To EXIT");
            Console.WriteLine("ENTER ANY ONE OPTION");
            int.TryParse(Console.ReadLine(), out option);
            return option;
        }
    }
}
