using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class angle 
    {
        public int degree;
        public float minutes;
        public char direction;
        public angle()
        {

        }
        public angle(int degree,float minutes,char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;

        }
    }
    class ship 
    {
       
       public angle longitude;
       public angle latitude;
       public string ship_number;
        public ship()
        {

        }
        public ship(angle longitude,angle latitude,string ship_number)
        {
            this.longitude = longitude;
            this.latitude =  latitude;
            this.ship_number  = ship_number;
        }

      
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<ship> Ship_Detail = new List<ship>();
            int option = -1;
            while (option != 5)
            {
                Console.Clear();
                option = menu();
                if (option == 1)
                {
                  ship s =  add_detail();
                    Ship_Detail.Add(s);
                    Console.ReadKey();
                }
               else if (option == 2)
                {
                    ViewShipPosition(Ship_Detail);
                }
                else if (option == 3)
                {
                    ViewShipSerialNumber(Ship_Detail);

                }
                else if (option == 4)
                {
                    Change_ship_position(Ship_Detail);
                }
            }
        }
        static int menu()
        {
            int choice;
            Console.WriteLine("Press 1. Add Ship");
            Console.WriteLine("Press 2. View Ship Position");
            Console.WriteLine("Press 3. View Ship Serial Number");
            Console.WriteLine("Press 4. Change Ship Position");
            Console.WriteLine("Press 5. Exit");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static ship add_detail()
        {
            int Degree = -1;
            float Minutes;
            char Direction = 'd';
            string ship_Number;
            Console.WriteLine("Longitude");

            while (Degree < 0 || Degree > 180)
            {
                Console.WriteLine("Enter Longitude’s Degree (0 to 180): ");
                Degree = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Minutes");
            Minutes = float.Parse(Console.ReadLine());

             while (Direction != 'E' && Direction != 'W')
            {
                Console.WriteLine("Enter Longitude’s Direction(Only \"E\" or \"W\"):");
                Direction = char.Parse(Console.ReadLine());

            }
           

            angle longitude = new angle(Degree, Minutes, Direction);

            Console.WriteLine("Latitude");
            while (Degree < 0 || Degree > 90)
            {
                Console.WriteLine("Enter Latitude’s Degree (0 to 90): ");
                Degree = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter minutes");
            Minutes = float.Parse(Console.ReadLine());

            while (Direction != 'S' && Direction != 'N')
            {
                Console.WriteLine("Enter Longitude’s Direction(Only \"S\" or \"N\"):");
                Direction = char.Parse(Console.ReadLine());

            
            }


            angle latitude = new angle(Degree, Minutes, Direction);

            Console.WriteLine("Enter ship serial number");
            ship_Number = Console.ReadLine();

            ship lost = new ship(longitude, latitude, ship_Number);
            return lost;
           
        }
       static void ViewShipPosition(List<ship> Ship_Detail)
        {
            string serial_NUmber;
            bool flag = false;
            Console.WriteLine("Enter ship serial number to find its position");
            serial_NUmber = Console.ReadLine();
            foreach (ship i in Ship_Detail)
            {
                if (i.ship_number == serial_NUmber)
                {
                    Console.WriteLine("Longitude: " + i.longitude.degree + "\u00b0"+" " + i.longitude.minutes + "\u00b0\u00b0" + " " + i.longitude.direction + "\u00b0\u00b0\u00b0");
                    Console.WriteLine("Latitude: " + i.latitude.degree + "\u00b0" + " " + i.latitude.minutes + "\u00b0\u00b0" + " " + i.latitude.direction + "\u00b0\u00b0\u00b0");
                    flag = true;
                    break;
                }
                if (flag == false)
                {
                    Console.WriteLine("Ship with serial number " + serial_NUmber + " not found");
                }
            }
            Console.ReadKey();
        }
        static void ViewShipSerialNumber(List<ship> Ship_Detail)
        {
            Console.WriteLine("List of all ship serial numbers:");
            foreach (ship s in Ship_Detail)
            {
                Console.WriteLine(s.ship_number);
            }
            Console.ReadKey();
        }
        static void Change_ship_position(List<ship> Ship_Detail)

        {
            int Degree;
            float Minutes;
            char Direction;
            string ship_Number;
            Console.WriteLine("Enter ship serial number which you want to find");
            ship_Number = Console.ReadLine();
            Console.WriteLine("Longitude");
            Console.WriteLine("Enter degree");
            Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter direction");
            Direction = char.Parse(Console.ReadLine());

            angle longitude = new angle(Degree, Minutes, Direction);
            foreach (ship s in Ship_Detail)
            {
                if (ship_Number == s.ship_number)
                {
                    s.longitude.degree = Degree;
                    s.longitude.minutes = Minutes;
                    s.longitude.direction = Direction;

                }
            }
            Console.WriteLine("Latitude");
            Console.WriteLine("Enter degree");
            Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter direction");
            Direction = char.Parse(Console.ReadLine());

            angle latitude = new angle(Degree, Minutes, Direction);

           
            foreach (ship s in Ship_Detail)
            {
                if (ship_Number == s.ship_number)
                {
                    s.latitude.degree = Degree;
                    s.latitude.minutes = Minutes;
                    s.latitude.direction = Direction;
                }
            }
            foreach (ship i in Ship_Detail)
            {
                
                
                    Console.WriteLine("Longitude: " + i.longitude.degree + "\u00b0" + " " + i.longitude.minutes + "\u00b0\u00b0" + " " + i.longitude.direction + "\u00b0\u00b0\u00b0");
                    Console.WriteLine("Latitude: " + i.latitude.degree + "\u00b0" + " " + i.latitude.minutes + "\u00b0\u00b0" + " " + i.latitude.direction + "\u00b0\u00b0\u00b0");
             
                    break;
                
               
            }

            Console.ReadKey();
        }
    }


}
