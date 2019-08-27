using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KitapKulubu.Models;

namespace KitapKulubu.Controllers
{
    public class DuyurularController : Controller
    {
        private KitapKulubuEntities db = new KitapKulubuEntities();

        // GET: Duyurular
        public ActionResult Index()
        {
            return View(db.Duyurular.ToList());
        }

        // GET: Duyurular/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyurular duyurular = db.Duyurular.Find(id);
            if (duyurular == null)
            {
                return HttpNotFound();
            }
            return View(duyurular);
        }

        // GET: Duyurular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Duyurular/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DuyuruID,duyuruBaslik,duyuruIcerik,duyuruTar")] Duyurular duyurular)
        {
            if (ModelState.IsValid)
            {
                db.Duyurular.Add(duyurular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duyurular);
        }

        // GET: Duyurular/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyurular duyurular = db.Duyurular.Find(id);
            if (duyurular == null)
            {
                return HttpNotFound();
            }
            return View(duyurular);
        }

        // POST: Duyurular/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DuyuruID,duyuruBaslik,duyuruIcerik,duyuruTar")] Duyurular duyurular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duyurular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duyurular);
        }

        // GET: Duyurular/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyurular duyurular = db.Duyurular.Find(id);
            if (duyurular == null)
            {
                return HttpNotFound();
            }
            return View(duyurular);
        }

        // POST: Duyurular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Duyurular duyurular = db.Duyurular.Find(id);
            db.Duyurular.Remove(duyurular);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
