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
    public class RezervasyonController : Controller
    {
        private KitapKulubuEntities db = new KitapKulubuEntities();

        // GET: Rezervasyon
        public ActionResult Index()
        {
            var rezervasyon = db.Rezervasyon.Include(r => r.Kitaplar).Include(r => r.Kullanicilar);
            return View(rezervasyon.ToList());
        }

        // GET: Rezervasyon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            return View(rezervasyon);
        }

        // GET: Rezervasyon/Create
        public ActionResult Create()
        {
            ViewBag.KitapID = new SelectList(db.Kitaplar, "KitapID", "kitapAd");
            ViewBag.KullanicilarID = new SelectList(db.Kullanicilar, "KullaniciID", "kullaniciAd");
            return View();
        }

        // POST: Rezervasyon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezervasyonID,KitapID,KullanicilarID,baslangicTar,bitisTar")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                db.Rezervasyon.Add(rezervasyon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KitapID = new SelectList(db.Kitaplar, "KitapID", "kitapAd", rezervasyon.KitapID);
            ViewBag.KullanicilarID = new SelectList(db.Kullanicilar, "KullaniciID", "kullaniciAd", rezervasyon.KullanicilarID);
            return View(rezervasyon);
        }

        // GET: Rezervasyon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            ViewBag.KitapID = new SelectList(db.Kitaplar, "KitapID", "kitapAd", rezervasyon.KitapID);
            ViewBag.KullanicilarID = new SelectList(db.Kullanicilar, "KullaniciID", "kullaniciAd", rezervasyon.KullanicilarID);
            return View(rezervasyon);
        }

        // POST: Rezervasyon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezervasyonID,KitapID,KullanicilarID,baslangicTar,bitisTar")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervasyon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KitapID = new SelectList(db.Kitaplar, "KitapID", "kitapAd", rezervasyon.KitapID);
            ViewBag.KullanicilarID = new SelectList(db.Kullanicilar, "KullaniciID", "kullaniciAd", rezervasyon.KullanicilarID);
            return View(rezervasyon);
        }

        // GET: Rezervasyon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            return View(rezervasyon);
        }

        // POST: Rezervasyon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            db.Rezervasyon.Remove(rezervasyon);
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
