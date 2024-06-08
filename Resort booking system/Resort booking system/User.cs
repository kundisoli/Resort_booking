using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resort_booking_system
{
    class User
    {

        private String username;
        private String password;
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

        public User(string username, string password)
        {

            this.username = username;
            this.password = password;
        }

        public User()
        {


        }

    }
}
