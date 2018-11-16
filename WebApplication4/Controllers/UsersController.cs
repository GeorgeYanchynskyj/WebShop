using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Tables;
using JustBusiness;

namespace Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {

            var userList = new List<UsersMod>{
                            new UsersMod() { UserID = 1, login = "John", password="invalid", basket=10, occupation="tester"  } ,
                            new UsersMod() { UserID = 2, login = "George", password="valid", basket=1, occupation="none"  }
                        };

            MarketLogic ml = new MarketLogic();
            List<Users> us = ml.getusers("byid");

            List<UsersMod> userList2 = new List<UsersMod>();
            foreach (Users u in us)
            {
                userList2.Add(new UsersMod(u));
            }
            
            return View(userList2);        
        }

        //public string Index()
        //{
        //    //ViewBag.Message = "what am i About ?";

        //    //return View();
        //    return "\n\n  Where are users ! ! !";
        //}

    }
}