using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animals.Models;

namespace Animals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        static List<LoginModels> logins = new List<LoginModels>();
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }
        public ActionResult Login(LoginModels login)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", login);
            }
            logins.Add(login);
            return RedirectToAction("Index");
        }
    }
}