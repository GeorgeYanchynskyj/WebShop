using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Tables;
using JustBusiness;

namespace MyFirstMvc.Controllers
{
    public class DiscountsController : Controller
    {
        // GET: Discounts
        public ActionResult Index()
        {
            MarketLogic ml = new MarketLogic();
            List<Discounts> ds = ml.getdiscounts();

            List<DiscountsMod> discountList2 = new List<DiscountsMod>();
            foreach (Discounts d in ds)
            {
                discountList2.Add(new DiscountsMod(d));
            }

            return View(discountList2);

            
        }
    }
}