using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resort_booking_system
{
    class Account
    {
        private string name;
        private string email;
        private string user_type;
        private string username;
        private string password;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string User_Type
        {
            get
            {
                return user_type;
            }
            set
            {
                user_type = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

          public Account(string name ,string email,string user_type, string username, string password)
        {
               this.name = name;
            this.email = email;
            this.user_type = user_type;
            this.username = username;
            this.password = password;
        }

          public Account()
        {

           
        } 


    }
}
