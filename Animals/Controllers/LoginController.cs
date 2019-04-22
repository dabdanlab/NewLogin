using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using Animals.App_Start;
using Animals.Models;
using MongoDB.Driver;

namespace Animals.Controllers
{
    public class LoginController : Controller
    {
        static List<LoginModels> logins = new List<LoginModels>();
        public ActionResult Index()
        {
            return View(logins);
        }
        public ActionResult Record(LoginModels logins)
        {
            return View(logins);
        }
        public ActionResult Login()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
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