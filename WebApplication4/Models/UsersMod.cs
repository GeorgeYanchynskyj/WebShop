using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tables;

namespace Models
{
    public class UsersMod
    {

        public int UserID { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String occupation { get; set; }
        public int basket { get; set; }

        public UsersMod()
        {

        }

        public UsersMod(Users u)
        {
            this.UserID = u.UserID;
            this.login = u.login;
            this.password = u.password;
            this.occupation = u.occupation;
            this.basket = u.basket;
        }

    }
}