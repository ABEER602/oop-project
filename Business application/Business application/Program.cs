using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using business_application.BL;

namespace business_application
{
    class Program
    {
        

        static void Main(string[] args)
        {
           
            LogIn obj = new LogIn();
            Owner obj1 = new Owner();

            obj.loadData();
            obj1.loadData();
            obj1.loadData1();
            obj1.loadData2();
            // obj.loadData1();

            int option = -1;
            while (option != 3)
            {
                int admin_option = -1;

                Console.Clear();
                option = login_Menu();
                Console.Clear();
                header();
                //for_discount();
                // discount_percent();
                if (option == 1)
                {
                    obj.signUP();
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    string result = obj.signIN();
                    if (result == "owner")
                        do
                        {
                            
                                
                                admin_option = admin_menu();
                                if (admin_option == 1)
                                {
                                    obj1.owner_option1();
                                }
                                else if (admin_option == 2)
                                {
                                    obj1.owner_option2();
                                }
                                else if (admin_option == 3)
                                {
                                obj1. owner_option3();
                                }

                                else if (admin_option == 4)

                                {
                                obj1.owner_option4();
                                }
                                else if (admin_option == 5)
                                {
                                obj1.owner_option5();
                                }
                                else if (admin_option == 6)
                                {
                                obj1.owner_option6();
                                }
                               
                                else if (admin_option == 7)
                                {

                                obj1.owner_option7();
                                }
                            
                        } while (admin_option != 9);
                    else
                    {
                        Console.WriteLine("WRONG ID");
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE-----");
                        Console.ReadKey();
                    }
                }
            }
        }
                //-----------------------------------------------------------
                //-------------------USER MENU-------------------------------
                //-----------------------------------------------------------
                public static int login_Menu()
                {
                    header();
                    int option;
                    Console.WriteLine("_________________Login Menu___________________");
                    Console.WriteLine("1. SignUP");
                    Console.WriteLine("2. SignIn");
                    Console.WriteLine("3. Exit ");
            Console.WriteLine("ENTER YOUR OPTION");
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Please enter a valid option number.");
            }
            return option;
        }
                //-------------------------------------------------------------------------
                //----------------------Admin menu---------------------------------------
                //-----------------------------------------------------------------------


                public static void header()
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine(" @  *********************************************  @");
                    Console.WriteLine(" @  *       BOTIQUE MANAGEMENT SYSTEM           *  @");
                    Console.WriteLine(" @  *********************************************  @");
                    Console.WriteLine(" @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                public static int admin_menu()
                {
                    Console.Clear();
                    header();
                    int options;

                    Console.WriteLine("OWNER MENU");
                    Console.WriteLine(" _______________________________________________________________");
                    Console.WriteLine("|   1- View employees (currently working)                      |");
                    Console.WriteLine("|   2- Add employees                                           |");
                    Console.WriteLine("|   3- Remove employees                                        |");
                    Console.WriteLine("|   4- View Stock of the shop                                  |");
                    Console.WriteLine("|   5- View bills                                              |");
                    Console.WriteLine("|   6- View ratings                                            |");
                    Console.WriteLine("|   7- View salary of employees                                |");
                    Console.WriteLine("|   8- View Customers                                          |");
                    Console.WriteLine("|   9- Exit menu                                               |");
                    Console.WriteLine(" _______________________________________________________________");
                    Console.WriteLine("Enter your option");

                    while (!int.TryParse(Console.ReadLine(), out options))
                    {
                        Console.WriteLine(" Enter a valid option number.");
                    }

                    return options;
                }
      


    }
}
