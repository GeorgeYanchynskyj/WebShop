using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBusiness;

namespace WebApplication4.Controllers
{
    public class DelDiscountController : Controller
    {
        // GET: DelDiscount
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string returnUrl)
        {
            var model = new DelDiscModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DelDiscModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            DiscountLogic nwdsc = new DiscountLogic();
            string res = nwdsc.delete(Int32.Parse(model.DiscountID));

            // Don't do this in production!


            // user authN failed
            ModelState.AddModelError("", res);
            return View();
        }
    }
}