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
    public class KitaplarController : Controller
    {
        private KitapKulubuEntities db = new KitapKulubuEntities();

        // GET: Kitaplar
        public ActionResult Index()
        {
            return View(db.Kitaplar.ToList());
        }

        // GET: Kitaplar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitaplar kitaplar = db.Kitaplar.Find(id);
            if (kitaplar == null)
            {
                return HttpNotFound();
            }
            return View(kitaplar);
        }

        // GET: Kitaplar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kitaplar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KitapID,kitapAd,yazar,Kategori,sayfasayisi,yayinevi,icerik,adet,kitapFoto")] Kitaplar kitaplar)
        {
            if (ModelState.IsValid)
            {
                db.Kitaplar.Add(kitaplar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kitaplar);
        }

        // GET: Kitaplar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitaplar kitaplar = db.Kitaplar.Find(id);
            if (kitaplar == null)
            {
                return HttpNotFound();
            }
            return View(kitaplar);
        }

        // POST: Kitaplar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KitapID,kitapAd,yazar,Kategori,sayfasayisi,yayinevi,icerik,adet,kitapFoto")] Kitaplar kitaplar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kitaplar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kitaplar);
        }

        // GET: Kitaplar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitaplar kitaplar = db.Kitaplar.Find(id);
            if (kitaplar == null)
            {
                return HttpNotFound();
            }
            return View(kitaplar);
        }

        // POST: Kitaplar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kitaplar kitaplar = db.Kitaplar.Find(id);
            db.Kitaplar.Remove(kitaplar);
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
