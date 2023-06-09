using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        class user_Details
        {

            public string user;
            public string password;
            public string role;
            public bool check = true;
        }

        static void Main(string[] args)
        {
            user_Details[] v = new user_Details[100];
            int count = 0;
            bool check = false;
            int option = -1;
            while (option != 3)
            {
                Console.Clear();
                option = login_Menu();
                Console.Clear();
                if (option == 1)
                {
                    signUp(v, count, check);
                }
                if (option == 2)
                {
                    Console.Clear();

                    string user;
                    string password;
                    string result1;
                    Console.WriteLine("Login Menu >> SignIn Menu");
                    Console.WriteLine("ENTER USERNAME");
                    user = Console.ReadLine();
                    Console.WriteLine("ENTER PASSWORD");
                    password = Console.ReadLine();
                    result1 = ToCheck(count, v, user, password);

                    if (result1 == "owner")
                    {
                        Console.WriteLine("Owner");
                    }
                    if (result1 == "customer")
                    {
                        Console.WriteLine("Customer");

                    }
                    if (result1 == "audit_manager")
                    {
                        Console.WriteLine("AUDIT_MANAGER");
                    }
                    if (result1 == "sales_man")
                    {
                        Console.WriteLine("SALES MAN");
                    }
                }
            }



        }

        //-----------------------------------------------------------
        //-------------------USER MENU-------------------------------
        //-----------------------------------------------------------
        static int login_Menu()
        {
            Console.Clear();
            int option;
            Console.WriteLine("___Login Menu___");
            Console.WriteLine("1. SignUP");
            Console.WriteLine("2. SignIn");
            Console.WriteLine("3. Exit ");
            Console.WriteLine("ENTER YOUR OPTION");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        //---------------------SIGN UP && SIGN IN-------------------------------------------------
        //----------------------------------------------------------------------------------------
        static void signUp(user_Details[] v, int count, bool check)
        {
            Console.Clear();
            user_Details v1 = new user_Details();
            string user;
            string password;
            string role;
            bool result;
            Console.WriteLine("Login Menu >> SignUp Menu");
            Console.WriteLine("ENTER USERNAME");
            user = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            password = Console.ReadLine();
            Console.WriteLine("ENTER YOUR ROLE(audit_manager , sales_man , owner , customer)");
            role = Console.ReadLine();
            result = isFound(count, v, user, password, role, check);
            if (result == false)
            {
                user_Details s = new user_Details();//NEW
                v[count] = s;
                Console.WriteLine("Successfully enetred");
                v[count].user = user;
                v[count].password = password;
                v[count].role = role;
                count++;

            }
            else
            {
                Console.WriteLine("Already exist");
                Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
            }
        }

        static void signIn(int count, user_Details[] v)
        {
            Console.Clear();
            string user;
            string password;
            string result1;
            Console.WriteLine("Login Menu >> SignIn Menu");
            Console.WriteLine("ENTER USERNAME");
            user = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            password = Console.ReadLine();
            result1 = ToCheck(count, v, user, password);
        }

        //------------------------------FUNCTIONS TO CHECK VALIDATIONS----------------------
        //----------------------------------------------------------------------------------
        static string ToCheck(int count, user_Details[] v, string user, string password)
        {

            for (int i = 0; i < count; i++)
            {
                if ((user == v[i].user) && (password == v[i].password))
                {
                    return v[i].role;
                }
            }
            return "undefined";
        }

        static bool isFound(int count, user_Details[] v, string user, string password, string role, bool check)
        {

            for (int i = 0; i < count; i++)
            {
                if ((v[i].user == user) && (v[i].password == password))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}