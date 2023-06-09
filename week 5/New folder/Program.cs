using challenge2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.UL;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            line line = new line();
            points point = new points();
            line_Interface inter = new line_Interface();
            int option;
            do
            {
               menu menus = new menu();
                option = menus.Menu();
                if (option == 1)
                {
                    int x = inter.printX();
                    int y = inter.printY();
                    point.forX();
                    point.forY();

                }
                else if (option == 2)
                {
                    point = inter.update_Starting_Point();
                    line.setStart(point);
                }
                else if (option == 3)
                {
                    point = inter.update_ENDING_Point();
                    line.setEnd(point);
                }
                else if (option == 4)
                {
                    point = line.getStart();
                    inter.Show_STARTING_Pointt(point);
                }
                else if (option == 5)
                {
                    point = line.getEnd();
                    inter.Show_ENDING_Point(point);
                }
                else if (option == 6)
                {
                    double distance = line.start.distanceFromZero();
                    inter.Starting_Distance_From_0(distance);
                }
                else if (option == 7)
                {
                    double endDistance = line.end.distanceFromZero();
                    inter.Ending_Distance_From_0(endDistance);
                }
                else if (option == 8)
                {
                    double gradient = line.getGradient();
                    inter.Show_Gradient(gradient);
                }
                else if (option == 9)
                {
                    double length = line.length();
                    inter.Show_Length(length);
                }
            }
            while (option != 10);
            Console.ReadKey();
        }
    }
}

