using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tables;

namespace Models
{
    public class PurchasesMod
    {

        public int PurchaseID { get; set; }
        public int UserID { get; set; }
        public int GoodID { get; set; }
        public int rating { get; set; }
        public DateTime date { get; set; }

        public PurchasesMod()
        {

        }

        public PurchasesMod(Purchases p)
        {

            this.PurchaseID = p.PurchaseID;
            this.UserID = p.UserID.UserID;
            this.GoodID = p.GoodID.GoodID;
            this.rating = p.rating;
            this.date = p.date;
        }
    }
}