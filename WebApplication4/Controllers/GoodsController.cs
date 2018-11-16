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
    public class GoodsController : Controller
    {
        // GET: Goods
        public ActionResult Index()
        {
            
            MarketLogic ml = new MarketLogic();
            List<Goods> gs = ml.getgoods("byid");

            List<GoodsMod> goodList2 = new List<GoodsMod>();
            foreach (Goods g in gs)
            {
                goodList2.Add(new GoodsMod(g));
            }

            return View(goodList2);
        }

        public ActionResult ByPrice()
        {
            MarketLogic ml = new MarketLogic();
            List<Goods> gs = ml.getgoods("byprice");
            List<GoodsMod> goodList2 = new List<GoodsMod>();
            foreach (Goods g in gs)
            {
                goodList2.Add(new GoodsMod(g));
            }
            return View(goodList2);
        }

        public ActionResult ByRating()
        {
            MarketLogic ml = new MarketLogic();
            List<Goods> gs = ml.getgoods("byrating");
            List<GoodsMod> goodList2 = new List<GoodsMod>();
            foreach (Goods g in gs)
            {
                goodList2.Add(new GoodsMod(g));
            }
            return View(goodList2);
        }

        public ActionResult ByBought()
        {
            MarketLogic ml = new MarketLogic();
            List<Goods> gs = ml.getgoods("bybought");
            List<GoodsMod> goodList2 = new List<GoodsMod>();
            foreach (Goods g in gs)
            {
                goodList2.Add(new GoodsMod(g));
            }
            return View(goodList2);
        }

        

        //public string ByPrice()
        //{



        //    return ("byprice");
        //}

        public ActionResult Sorted(string by)
        {



            MarketLogic ml = new MarketLogic();
            List<Goods> gs = ml.getgoods(by);

            List<GoodsMod> goodList2 = new List<GoodsMod>();
            foreach (Goods g in gs)
            {
                goodList2.Add(new GoodsMod(g));
            }

            return View(goodList2);
        }



        //public string Index()
        //{
        //    //return View();
        //    return "\n\n  that's no good";
        //}
    }
}