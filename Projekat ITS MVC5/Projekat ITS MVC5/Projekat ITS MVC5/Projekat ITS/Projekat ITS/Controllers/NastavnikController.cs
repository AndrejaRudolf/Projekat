using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projekat_ITS.Context;
using Projekat_ITS.Models;

namespace Projekat_ITS.Controllers
{
    public class NastavnikController : Controller
    {
        UcenikContext db = new UcenikContext();
        // GET: Nastavnik
        public ActionResult Index()
        {


            return View(db.Ucenik.ToList());
        }

        public ActionResult Details(int ?id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Ucenik ucenik = db.Ucenik.Find(id);
            if(ucenik==null)
                return HttpNotFound();
            return View(ucenik);

        }
    }
}