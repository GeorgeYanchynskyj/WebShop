﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    [Authorize(Roles = "marketologist")]
    public class MarketingController : Controller
    {
        // GET: Marketing
        public ActionResult Marketing()
        {


            return View();
        }
    }
}
