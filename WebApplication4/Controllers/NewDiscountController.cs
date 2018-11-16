using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBusiness;
using Tables;


namespace WebApplication4.Controllers
{
    public class NewDiscountController : Controller
    {
        // GET: NewDiscount
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string returnUrl)
        {
            var model = new NewDiscModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(NewDiscModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            DiscountLogic nwdsc = new DiscountLogic ();
            string res = nwdsc.addnew(Int32.Parse( model.UserID), Int32.Parse(model.GoodID), Int32.Parse(model.percents));

            // Don't do this in production!
            

            // user authN failed
            ModelState.AddModelError("", res);
            return View();
        }
    }
}