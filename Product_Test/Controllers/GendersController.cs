using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Product_Test.Models;

namespace Product_Test.Controllers
{
    public class GendersController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();

        // GET: Genders
        public ActionResult Index()
        {
            return View(dbContext.Genders.ToList());
        }

        // GET: Genders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gender gender = dbContext.Genders.Find(id);
            if (gender == null)
            {
                return HttpNotFound();
            }
            return View(gender);
        }

        // GET: Genders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Gender gender)
        {
            if (ModelState.IsValid)
            {
                dbContext.Genders.Add(gender);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gender);
        }

        // GET: Genders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gender gender = dbContext.Genders.Find(id);
            if (gender == null)
            {
                return HttpNotFound();
            }
            return View(gender);
        }

        // POST: Genders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Gender gender)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(gender).State = EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gender);
        }

        // GET: Genders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gender gender = dbContext.Genders.Find(id);
            if (gender == null)
            {
                return HttpNotFound();
            }
            return View(gender);
        }

        // POST: Genders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gender gender = dbContext.Genders.Find(id);
            dbContext.Genders.Remove(gender);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
