using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Tables;
using JustBusiness;

namespace WebApplication4.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult HistoryInd()
        {
            History ml = new History();
            List<Purchases> gs = ml.getpurchases();

            List<PurchasesMod> goodList2 = new List<PurchasesMod>();
            foreach (Purchases g in gs)
            {
                goodList2.Add(new PurchasesMod(g));
            }

            return View(goodList2);
        }
    }
}