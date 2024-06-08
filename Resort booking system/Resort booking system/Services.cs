using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resort_booking_system
{
    class Services
    {
        private int service_id;
               private int number_of_adults;
        private int number_of_children;
        private string roomtype;
        private string restaurant_name;
        private string reservation_type;
        private string ride_type;
        

        public int Service_id
        {
            get
            {
                return service_id;
            }
            set
            {
                service_id = value;
            }
        }
      
        public int Number_of_adults
        {
            get
            {
                return number_of_adults;
            }
            set
            {
                number_of_adults = value;
            }
        }
        public int Number_of_children
        {
            get
            {
                return number_of_children;
            }
            set
            {
                number_of_children = value;
            }
        }

        public string Roomtype
        {
            get
            {
                return roomtype;
            }
            set
            {
                roomtype = value;
            }
        }
        public string Restaurant_name
        {
            get
            {
                return restaurant_name;
            }
            set
            {
                restaurant_name = value;
            }
        }
        public string Reservation_type
        {
            get
            {
                return reservation_type;
            }
            set
            {
                reservation_type = value;
            }
        }

        public string Ride_type
        {
            get
            {
                return ride_type;
            }
            set
            {
                ride_type = value;
            }
        }

        

        public Services(int service_id,int number_of_adults,int number_of_children, string roomtype, string restaurant_name, string reservation_type,string ride_type)
        {

            this.service_id= service_id;
            
            this.number_of_adults =number_of_adults;
            this.number_of_children = number_of_children;
            this.roomtype = roomtype;
            this.restaurant_name =restaurant_name;
            this.ride_type = ride_type;
            
        }

        public Services()
        {

           
        } 
    }



}
