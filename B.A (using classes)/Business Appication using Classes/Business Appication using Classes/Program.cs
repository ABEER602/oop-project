using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business_Appication_using_Classes
{
    class Program
    {
        class user_Details
        {

            public string user;
            public string password;
            public string role;
            public int salary;
            public bool check = true;
        }
        class products_details
        {
            public string current_items;
            public int current_pieces;
            public int current_prices;
        }
        class Expenditure_details
        {
            public int electric_bills;
            public int food_bills; 
            public int money_spend_on_stock;
            public int total_expenditure;
        }


        static void Main(string[] args)
        {
            user_Details v = new user_Details();
            products_details p = new products_details();
            Expenditure_details e = new Expenditure_details();
            List<products_details> product_Array = new List<products_details>();
            List<user_Details> user_Array = new List<user_Details>();
            List<Expenditure_details> expenditure_Details = new List<Expenditure_details>();

            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/userDetails.txt";
            string path1 = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/Expenditure.txt";
            string path2 = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/Stock.txt";
            loadData(path, v, user_Array);
            loadData1(path1, expenditure_Details, e);
            loadData2(path2, product_Array, p);
            bool check = false;
            int option = -1;
            int admin_option = -1;
            while (option != 3)
            {
                Console.Clear();
                option = login_Menu();
                Console.Clear();
                if (option == 1)
                {
                    signUp(user_Array, v, check);
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
                    result1 = ToCheck(user_Array, user, password);


                    if (result1 == "owner")
                        while (admin_option != 9)
                        {
                            {
                                admin_option = admin_menu();
                                if (admin_option == 1)
                                {
                                    owner_option1(user_Array);
                                }
                                else if (admin_option == 2)
                                {
                                    owner_option2(user_Array, v, check);
                                }
                                else if (admin_option == 3)
                                {
                                    owner_option3(user_Array, v, check);
                                }

                                else if (admin_option == 4)

                                {
                                    Owner_option4(product_Array);
                                }
                                else if (admin_option == 5)
                                {
                                    owner_option5(expenditure_Details);
                                }
                              //  else if (admin_option == 6)
                                //{
                                  //  owner_option6(ref count3, ref Feedback);
                                //}
                                else if (admin_option == 7)
                                {
                                    owner_option7( user_Array);
                                }
                                else if (admin_option == 8)
                                {

                                    owner_option8(user_Array);
                                }
                            }
                        }
                    else
                    {
                        Console.WriteLine("WRONG ID");
                        press_key();
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
        static void signUp(List<user_Details> user_Array, user_Details v, bool check)
        {
            Console.Clear();
            user_Details v1 = new user_Details();

            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/userDetails.txt";
            string user1;
            string password1;
            string role1;
            bool result;
            Console.WriteLine("Login Menu >> SignUp Menu");
            Console.WriteLine("ENTER USERNAME");
            user1 = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            password1 = Console.ReadLine();
            Console.WriteLine("ENTER YOUR ROLE(audit_manager , sales_man , owner , customer)");
            role1 = Console.ReadLine();
            result = isFound(user_Array, user1, password1, role1, check);
            if (result == false)
            {


                Console.WriteLine("Successfully enetred");
                storeData(user_Array, v, path, user1, password1, role1, 0);

            }
            else
            {
                Console.WriteLine("Already exist");
                Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
            }
        }

        static void signIn(List<user_Details> user_Array)
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
            result1 = ToCheck(user_Array, user, password);
        }

        //------------------------------FUNCTIONS TO CHECK VALIDATIONS----------------------
        //----------------------------------------------------------------------------------
        static string ToCheck(List<user_Details> user_Array, string user, string password)
        {

            for (int i = 0; i < user_Array.Count; i++)
            {
                if ((user == user_Array[i].user) && (password == user_Array[i].password))
                {
                    return user_Array[i].role;
                }
            }
            return "undefined";
        }

        static bool isFound(List<user_Details> user_Array, string user1, string password1, string role1, bool check)
        {

            for (int i = 0; i < user_Array.Count; i++)
            {
                if ((user_Array[i].user == user1) && (user_Array[i].password == password1))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        static void press_key()
        {
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }

        //-------------------------------------------------------------------------
        //----------------------Admin menu---------------------------------------
        //-----------------------------------------------------------------------


        static void header()
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
        static int admin_menu()
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
            Console.WriteLine("|   7- View salary of emploies                                 |");
            Console.WriteLine("|   8- View Customers                                          |");
            Console.WriteLine("|   9- Exit menu                                               |");
            Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine("Enter your option");
            options = int.Parse(Console.ReadLine());
            return options;
        }

        //<><><><><><><><><><><><><><><><><><><><><><><><>><<><><><><><><//
        //>>>>>>>>>>>>>>>>>>>>>>OWNER OPTIONS <<<<<<<<<<<<<<<<<<<<<<<<<<//
        //><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>//

        static void owner_option1(List<user_Details> user_Array)
        {
            Console.WriteLine("USER_NAME" + "\t" + "PASSWORDS" + "\t" + "ROLES");
            for (int i = 0; i < user_Array.Count; i++)
            {
                if (user_Array[i].role == "sales_man" || user_Array[i].role == "audit_manager")
                {

                    Console.WriteLine(user_Array[i].user + "\t" + user_Array[i].password + "\t" + user_Array[i].role);
                }
            }
            press_key();
        }
        static void owner_option2(List<user_Details> user_Array, user_Details v, bool check)
        {



            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/userDetails.txt";
            string user1;
            string password1;
            string role1;
            int employ_salary;
            bool result;
            Console.WriteLine("ENTER EMPLOY NAME");
            user1 = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY PASSWORD");
            password1 = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY ROLE(audit_manager , sales_man)");
            role1 = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY SALARY");
            employ_salary = int.Parse(Console.ReadLine());
            result = isFound(user_Array, user1, password1, role1, check);
            if (result == false)
            {
                Console.WriteLine("Successfully enetred");

                storeData(user_Array, v, path, user1, password1, role1, employ_salary);
            }
            else
            {
                press_key();
            }
        }
        static void owner_option3(List<user_Details> user_Array, user_Details v, bool check)
        {
            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/userDetails.txt";
            string user1;
            string password1;
            string role1;
            //bool result = false;
            Console.WriteLine("Enter name of employ");
            user1 = Console.ReadLine();
            Console.WriteLine("Enter password of employ");
            password1 = Console.ReadLine();
            Console.WriteLine("Enter role of employ");
            role1 = Console.ReadLine();
            for (int i = 0; i < user_Array.Count; i++)
            {
                if (user_Array[i].user == user1 && user_Array[i].password == password1 && user_Array[i].role == role1)
                {
                    user_Array.RemoveAt(i);
                    Console.WriteLine("DELETED SUCCESSFULLY");
                    storeData(user_Array, v, path, user1, password1, role1, 0);

                    break;
                }
            }
            press_key();
        }


        static void Owner_option4(List<products_details> product_Array)
        {

            {

                Console.WriteLine("CURRENT ITEMS "
                     + "\t\t"
                     + "CURRENT PIECES"
                     + "\t\t"
                     + "CURRENT PRICES");
                for (int i = 0; i < product_Array.Count; i++)
                {
                    if ((product_Array[i].current_items != "#") && (product_Array[i].current_pieces != 0) && (product_Array[i].current_prices != 0))
                    {
                        Console.WriteLine(product_Array[i].current_items + "\t\t\t\t" + product_Array[i].current_pieces + "\t\t\t\t" + product_Array[i].current_prices);
                    }
                }
                press_key();
            }
        }
        static void owner_option5(List<Expenditure_details> expenditure_Details)
        {
            Console.WriteLine("ELECTRIC BILL"
                 + "\t"
                 + "FOOD BILL"
                 + "\t"
                 + "STOCK BILL"
                 + "\t"
                 + "TOTAL BILL");
            for (int i = 0; i <  expenditure_Details.Count; i++)
            {
                Console.WriteLine(expenditure_Details[i].electric_bills + "\t"
                     + "\t" + expenditure_Details[i].food_bills + "\t"
                     + "\t" + expenditure_Details[i].money_spend_on_stock + "\t"
                     + "\t" + expenditure_Details[i].total_expenditure);
            }
            press_key();
        }
        static void owner_option6(ref int count3, ref string[] Feedback)
        {
            for (int i = 0; i < count3; i++)
            {
                Console.WriteLine("FOLLOWING ARE THE FEEDBACKS GIVEN BY YOUR CUSTOMERS");
                Console.WriteLine(Feedback[i]);
            }
            press_key();
        }

         static void owner_option7(List<user_Details> user_Array)
        {

            {
                for (int i = 0; i < user_Array.Count; i++)
                {
                    if (user_Array[i].role == "sales_man" || user_Array[i].role == "audit_manager")
                    {
                        if (user_Array[i].salary > 0)
                            Console.WriteLine(user_Array[i].user + "\t" + user_Array[i].password+ "\t" + user_Array[i].role + "\t" + user_Array[i].salary);
                    }
                }
                press_key();
            }
        }

        static void owner_option8(List<user_Details> user_Array)
        {

            for (int i = 0; i <  user_Array.Count; i++)
            {
                if (user_Array[i].user == "customer")
                {
                    Console.WriteLine(user_Array[i].user + "\t" + user_Array[i].password);
                }
            }
            press_key();
        }
        //---------------------------------------------------------------------------
        //------------FILE HANDLING FUNCTIONS----------------------------------------
        //---------------------------------------------------------------------------

        static void storeData(List<user_Details> user_Array, user_Details v, string path, string user1, string password1, string role1, int salary)
        {


  
            StreamWriter filevariable = new StreamWriter(path, true);
            for (int x = 0; x < user_Array.Count; x++)
            {
                filevariable.WriteLine(user_Array[x].user + ","
                     + user_Array[x].password+ ","
                     + user_Array[x].role + ","
                     + user_Array[x].salary + ",");
                filevariable.Flush();
            }
            filevariable.Close();
            Console.Read();
           

        }

        static string getField(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {

                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;

        }

        static void loadData(string path, user_Details v, List<user_Details> user_Array)
        {

            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    v.user = getField(record, 1);
                    v.password = getField(record, 2);
                    v.role = getField(record, 3);
                    v.salary = int.Parse((getField(record, 4)));
                    user_Array.Add(v);

                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();

        }

        
       static void storeData1(ref int Bill_count,ref int[] electric_bills,ref int[] food_bills,ref int[] money_spend_on_stock,ref int[] total_expenditure)
        {
            string path1 = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/Expenditure.txt";
            StreamWriter filevariable = new StreamWriter(path1, true);
            for (int x = 0; x <Bill_count; x++)
            {
                filevariable.WriteLine( electric_bills[x] + ","
                     + food_bills[x] + ","
                     + money_spend_on_stock[x] + ","
                     + total_expenditure[x] + "," );
                filevariable.Flush();
            }
            filevariable.Close();
            Console.Read();
        }

        static string getField1(string record, int field)
        {

            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {

                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;

        }

       static void loadData1(string path1, List<Expenditure_details> expenditure_Details, Expenditure_details e)
        {

            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {

                    e.electric_bills = int.Parse((getField1(record, 1)));
                    e.food_bills = int.Parse((getField1(record, 2)));
                    e.money_spend_on_stock = int.Parse((getField1(record, 3)));
                    e.total_expenditure = int.Parse((getField1(record, 4)));
                    expenditure_Details.Add(e);


                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
           
        }


        static void storeData2(ref int stockCount, ref int[] current_pieces, ref int[] current_prices, ref string[] current_items)
        {
            string path2 = "C:/Users/abeer/OneDrive/Desktop/Semester 2/OOP (PD's)/Stock.txt";
            StreamWriter filevariable = new StreamWriter(path2, true);
            for (int x = 0; x < stockCount; x++)
            {
                filevariable.WriteLine(current_items[x] + ","
                     + current_pieces[x] + ","
                     + current_prices[x] + ","
                     );
                filevariable.Flush();
            }
            filevariable.Close();
            Console.Read();

        }

        static string getField2(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {

                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static void loadData2(string path2, List<products_details> product_Array,products_details p )
        {
            if (File.Exists(path2))
            {
                StreamReader fileVariable = new StreamReader(path2);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {

                    p.current_items= (getField2(record, 1));
                    p.current_pieces = int.Parse((getField1(record, 2)));
                    p.current_prices = int.Parse((getField1(record, 3)));
                    product_Array.Add(p);

                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();

        }
    }
}

