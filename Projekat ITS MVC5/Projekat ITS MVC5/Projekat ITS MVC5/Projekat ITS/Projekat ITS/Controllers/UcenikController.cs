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
    public class UcenikController : Controller
    {
        UcenikContext db = new UcenikContext();
        // GET: Ucenik
        public ActionResult Index()
        {

            return View(db.Ucenik.ToList());
        }

        // GET: Ucenik/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Ucenik ucenik = db.Ucenik.Find(id);
            if (ucenik == null)
                return HttpNotFound();
            return View(ucenik);
        }

        // GET: Ucenik/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ucenik/Create
        [HttpPost]
        public ActionResult Create(Ucenik ucenik)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Ucenik.Add(ucenik);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ucenik);
            }
            catch
            {
                return View();
            }
        }

        // GET: Ucenik/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Ucenik ucenik = db.Ucenik.Find(id);
            if (ucenik == null)
                return HttpNotFound();
            return View(ucenik);
        }

        // POST: Ucenik/Edit/5
        [HttpPost]
        public ActionResult Edit(Ucenik ucenik)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(ucenik).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ucenik);
            }
            catch
            {
                return View();
            }
        }

        // GET: Ucenik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ucenik/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
