using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.BL;

namespace challenge2.UL
{
    class line_Interface
    {
        public int printX()
        {
            Console.WriteLine("ENTER VALUE OF X TO MAKE LINE");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        public int printY()
        {
            Console.WriteLine("ENTER VALUE OF Y TO MAKE LINE");
            int y = int.Parse(Console.ReadLine());
            return y;
        }

        public points update_Starting_Point()
        {
            points point = new points();
            Console.WriteLine("ENTER VALUE OF X TO UPDATE SATRT OF LINE");
            point.x = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER VALUE OF Y TO UPDATE START OF LINE");
            point.y = int.Parse(Console.ReadLine());
            return point;
        }

        public points update_ENDING_Point()
        {
            points point = new points();
            Console.WriteLine("ENTER VALUE OF X TO UPDATE END OF LINE");
            point.x = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER VALUE OF Y TO UPDATE END OF LINE");
            point.y = int.Parse(Console.ReadLine());
            return point;
        }

        public void Show_STARTING_Pointt(points point)
        {
            Console.WriteLine("X's STARTING POINT IS" + point.x + " Y's STARTING POINT IS " + point.y);
        }
        public void Show_ENDING_Point(points point)
        {
            Console.WriteLine("X's ENDING POINT IS " + point.x + " Y's ENDING POINT IS " + point.y);
        }
        public void Starting_Distance_From_0(double distance)
        {
            Console.WriteLine("THE DISTANCE OF START POINT FROM ZERO FROM THE ZERO COORDINATES " + distance);
        }

        public void Ending_Distance_From_0(double distance)
        {
            Console.WriteLine("THE DISTANCE OF END POINT FROM ZERO FROM THE ZERO COORDINATES  " + distance);
        }

        public void Show_Gradient(double gradient)
        {
            Console.WriteLine("THE GARDIENT OF LINE IS " + gradient);
        }

        public void Show_Length(double length)
        {
            Console.WriteLine("LINE's LENGTH IS" + length);

        }
    }
}
