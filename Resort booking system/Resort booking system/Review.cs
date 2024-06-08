using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resort_booking_system
{
    class Review
    {
        private string customer_username;
        private string comment;

        public string Customer_username
        {
            get
            {
                return   customer_username;
            }
            set
            {
                customer_username = value;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }
        
        public Review(string customer_username, string comment)
        {
            this.customer_username = customer_username;
            this.comment = comment;
           
        }

        public Review()
        {
            
        } 


    }
    }

