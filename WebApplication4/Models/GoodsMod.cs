using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Tables;


namespace Models
{
    public class GoodsMod
    {
        public int GoodID { get; set; }
        public String name { get; set; }
        public bool available { get; set; }
        public int rating { get; set; }
        public string producer { get; set; }
        public int bought { get; set; }
        public int price { get; set; }

        public GoodsMod()
        {

        }

        public GoodsMod(Goods g)
        {
            this.GoodID = g.GoodID;
            this.name = g.name;
            this.available = g.available;
            this.rating = g.rating;
            this.producer = g.producer;
            this.bought = g.bought;
            this.price = g.price;
        }

        //public override String ToString()
        //{
        //    return "GoodID= " + GoodID + " name=" + name + " available=" + available + " rating" + rating + "producer" + producer + "bought" + bought + "price" + price;
        //}
    }
}
