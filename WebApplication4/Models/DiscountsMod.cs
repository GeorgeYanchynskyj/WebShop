using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tables;

namespace Models
{
    public class DiscountsMod
    {

        public int DiscountID { get; set; }
        public int UserID { get; set; }
        public int GoodID { get; set; }
        public int percent { get; set; }

        public DiscountsMod()
        {

        }

        public DiscountsMod(Discounts d)
        {
            
            this.DiscountID = d.DiscountID;
            this.UserID = d.UserID.UserID;
            this.GoodID = d.GoodID.GoodID;
            this.percent = d.percents;
        }

    }
}