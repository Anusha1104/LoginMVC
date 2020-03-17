using LoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Check(Login L)
        {
            if (ModelState.IsValid)
            {
                bool b=DBOperations.Login(L);
                if (b)
                    return RedirectToAction("Home");
                else
                {
                    ViewBag.msg = "Invalid Credentials";
                    return View("Index");
                }
            }
               
            else
                return View("Index");
        }

        public ActionResult Home()
        {
            return View();
        }


    }
}