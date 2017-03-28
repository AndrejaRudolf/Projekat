using Projekat_ITS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat_ITS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if ("admin".Equals(name) && "123".Equals(password))
            {
                //Session["user"] = new User() {LogIn = name, Name = "Andreja Rudolf"};
                return RedirectToAction("Index", "Ucenik");
            }
            if ("nastavnik".Equals(name) && "456".Equals(password))
            {
                return RedirectToAction("Index", "Nastavnik");
            }
            return View();
        }
    }
}