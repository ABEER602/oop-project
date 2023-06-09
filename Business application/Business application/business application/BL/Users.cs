using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_application.BL
{
    class Users
    {
        public string Name;
        public string Password;
        public string Role;

        // parameterized constructor
        public Users(string name , string password , string role)
        {
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }
        public Users(string name , string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public Users()
        {

        }

        // function
        public bool isAdmin()
        {
            if (Role == "admin" || Role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
