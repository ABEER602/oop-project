using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace business_application.BL
{
    public class Owner
    {

        public List<User> users = new List<User>();
        public List<Item> CurrentItems = new List<Item>();
        public List<Bill> Bills = new List<Bill>();
        public List<Feedback> Feedbacks = new List<Feedback>();

        public void Add_User(User user_detail)
        {
            users.Add(user_detail);
        }
        public void Add_Item(Item item)
        {
            CurrentItems.Add(item);
        }

        public void Add_Expenditure(Bill bill)
        {
            Bills.Add(bill);
        }
        public void Add_Feedback(Feedback obj)
        {
            Feedbacks.Add(obj);
        }

        //<><><><><><><><><><><><><><><><><><><><><><><><>><<><><><><><><//
        //>>>>>>>>>>>>>>>>>>>>>>OWNER OPTIONS <<<<<<<<<<<<<<<<<<<<<<<<<<//
        //><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>//
        public void owner_option1()
        {
            Console.WriteLine("USER_NAME" + "\t" + "PASSWORDS" + "\t" + "ROLES");
            foreach (User user in users)
            {
                Console.WriteLine("hj");
                if (user.Role == "sales_man" || user.Role == "audit_manager")
                {
                    Console.WriteLine(user.UserName + "\t" + user.Passcode + "\t" + user.Role);
                }
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }



        public void owner_option2()
        {
            LogIn obj = new LogIn();
            Owner obj1 = new Owner();
            ;
            string user;
            string password;
            string role;
            int employ_salary;
            bool result;
            Console.WriteLine("ENTER EMPLOY NAME");
            user = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY PASSWORD");
            password = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY ROLE(audit_manager , sales_man)");
            role = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOY SALARY");
            employ_salary = int.Parse(Console.ReadLine());
            result = obj.IsFound(users, user, password);

            if (result == false)
            {

                User obj2 = new User(user, password, role);
                Add_User(obj2);
                storeData(obj2);
                Console.WriteLine("Successfully enetred");

            }
            else
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
            }

        }



        public void owner_option3()
        {
            LogIn obj = new LogIn();
            string user1;
            string password;
            string role;
            //bool result = false;
            Console.WriteLine("Enter name of employ");
            user1 = Console.ReadLine();
            Console.WriteLine("Enter password of employ");
            password = Console.ReadLine();
            Console.WriteLine("Enter role of employ");
            role = Console.ReadLine();

            foreach (User user in users)
            {
                if (user.UserName == user1 && user.Passcode == password && user.Role == role)
                {
                    users.Remove(user);

                    Console.WriteLine("DELETED SUCCESSFULLY");
                    obj.storerRemoveData(); //new

                    break;
                }
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }

        public void owner_option4()
        {

            {
                LogIn obj = new LogIn();
                obj.loadData2();
                Console.WriteLine("CURRENT ITEMS "
                     + "\t\t"
                     + "CURRENT PIECES"
                     + "\t\t"
                     + "CURRENT PRICES");
                foreach (Item item in CurrentItems)
                {


                    Console.WriteLine(item.Product_Name + "\t\t\t\t" + item.Pieces + "\t\t\t\t" + item.Price);

                }
                Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
            }
        }
        public void owner_option5()
        {

            Console.WriteLine("ELECTRIC BILL"
                 + "\t"
                 + "FOOD BILL"
                 + "\t"
                 + "STOCK BILL"
                 + "\t"
                 + "TOTAL BILL");
            foreach (Bill bill in Bills)
            {
                Console.WriteLine(bill.ElectricBills + "\t"
                     + "\t" + bill.FoodBills + "\t"
                     + "\t" + bill.MoneySpendOnStock + "\t"
                     + "\t" + bill.TotalExpenditure);
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }
        public void owner_option6()
        {
            foreach (Feedback custom in Feedbacks)
            {
                Console.WriteLine("FOLLOWING ARE THE FEEDBACKS GIVEN BY YOUR CUSTOMERS");
                Console.WriteLine(custom.feedback);
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }

        public void owner_option7()
        {
            foreach (User user in users)
            {
                if (user.Role == "Customer")
                {

                    Console.WriteLine(user.UserName + "\t" + user.Passcode);
                }
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
        }
        public void loadData()
        {
            string path = "userDetails.txt";

            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    User user = new User();
                   user.UserName = getField(record, 1);
                    user.Passcode = getField(record, 2);
                    user.Role = getField(record, 3);
                   
                    users.Add(user);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            Console.ReadKey();

        }

        public string getField(string record, int field)
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

        public void storeData(User user)
        {
            string path = "userDetails.txt";
            StreamWriter filevariable = new StreamWriter(path, true);


            filevariable.WriteLine(user.UserName + ","
                + user.Passcode + ","
                + user.Role);
            filevariable.Flush();

            filevariable.Close();

        }
    }
}
