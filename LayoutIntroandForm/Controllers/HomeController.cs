using LayoutIntroandForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutIntroandForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Signup s)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Login");
            }
            return View(s);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login l)
        {
            return View(l);
        }

        public ActionResult LoginSubmit()
        {
            //validation
            //authentication
            TempData["msg"] = "Login Successfull";
            //return Redirect("https://www.aiub.edu");
            return RedirectToAction("Index", "Dashboard");
        }
    }
}