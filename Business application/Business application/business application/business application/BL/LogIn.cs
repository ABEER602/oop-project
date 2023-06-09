using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace business_application.BL
{
    public class LogIn
    {
        public string Name;
        public string password;
        public string role;
        public List<User> users = new List<User>();

        public LogIn()
        {

        }

      public void storerRemoveData()
        {
            string path = "C://Users/abeer//OneDrive//Desktop//Semester 2//OOP (PD's)//userDetails.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int x = 0; x < users.Count; x++)
            {
                file.WriteLine(users[x].UserName + "," + users[x].Passcode + "," + users[x].Role);
            }
            file.Flush();
            file.Close();
        }

        public void AddIntoList(User s)
        {
            users.Add(s);
        }

        public void signUP()
        {
            Console.Clear();
            header();

            string user;
            string password;
            string role;
            bool result;

            Console.WriteLine("Login Menu >> SignUp Menu");
            Console.WriteLine("ENTER USERNAME");
            user = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            password = Console.ReadLine();
            Console.WriteLine("ENTER YOUR ROLE (audit_manager, sales_man, owner, customer)");
            role = Console.ReadLine();
            Owner obj1 = new Owner();
            User s = new User(user, password, role);
            result = IsFound(users, user, password);

            if (result == false)
            {
                Console.WriteLine("Successfully entered");
                AddIntoList(s);
                obj1.storeData(s);
            }
            else
            {
                Console.WriteLine("Already exists");
                Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
            }
        }

        public string signIN()
        {
            Console.Clear();
            header();
            string user;
            string password;
            string result1;

            Console.WriteLine("Login Menu >> SignIn Menu");
            Console.WriteLine("ENTER USERNAME");
            user = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            password = Console.ReadLine();
            result1 = ToCheck(user, password);
            return result1;
        }

        public List<User> returnList()
        {
           return users;
        }
        public bool IsFound(List<User> users, string username, string password)
        {
            bool check = false;
            foreach (User user in users)
            {
                if (user.UserName == username && user.Passcode == password)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public string ToCheck(string applicant, string password)
        {
            foreach (User user in users)
            {
                if (user.UserName == applicant && user.Passcode == password)
                {
                    return user.Role;
                }
            }
            return "undefined";
        }

       


        public void header()
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


    }



   
    public class User
    {
        public string UserName;
        public string Passcode;
        public string Role;
        public int Salary;
        public User()
            {

            }
        public User(string UserName, string Passcode, string Role)
        {
            this.UserName = UserName;
            this.Passcode = Passcode;
            this.Role = Role;
        }
    }
    public class Item
    {
        public string Product_Name;
        public int Pieces;
        public int Price;
    }

    public class Bill
    {
        public int ElectricBills;
        public int FoodBills;
        public int MoneySpendOnStock;
        public int TotalExpenditure;
    }

    public class Feedback
    {
        public string feedback;
    }

}





