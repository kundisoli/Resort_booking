using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resort_booking_system
{
    class Admin : User
    {
        private int failedLogins;
        private Boolean locked;
        public int FailedLogins
        {
            get
            {
                return failedLogins;
            }
            set
            {
                failedLogins = value;
            }
        }
        public bool Locked
        {
            get
            {
                return locked;
            }
            set
            {
                locked = value;
            }
        }
        public override Boolean checkPassword(String pass)
        {
            Boolean ret;
            if (locked == true)
            {
                return false;
            }
            ret = base.checkPassword(pass);
            if (ret == false)
            {
                failedLogins += 1;
                if (failedLogins == 3)
                {
                    locked = true;
                }
                return false;
            }
            else
            {
                failedLogins = 0;
                return true;
            }

        }

    }
}

